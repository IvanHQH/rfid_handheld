using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Symbol.RFID3;
using System.Threading;
using System.IO;
using MobileEPC;
using ReadWriteCsv;
using System.Runtime.InteropServices;

namespace AxesoFeng
{
    public class SimpleRFID
    {
        public delegate void EventRead(String tag);
        public EventRead ReadHandler = delegate(String tag) { };

        public delegate void TriggerStop();
        public TriggerStop TriggerStopHandler = delegate() { };

        public delegate bool ValidTag(String tag);
        public ValidTag ValidTagHandler = delegate(String tag) { return true; };

        public delegate void LocationTag(short relatived);
        public LocationTag LocationHandler = delegate(short relatived) {};

        public bool isReading = false;
        internal RFIDReader m_ReaderAPI;
        public Hashtable m_TagTable;

        public bool isTriggerActive = false;
        
        const uint MB_OK = 0x00000000;

        [DllImport("coredll.dll")]
        internal static extern bool MessageBeep([In] UInt32 beepType);

        public SimpleRFID() {
            try {
                m_ReaderAPI = new RFIDReader("localhost", 5084, 0);
                m_ReaderAPI.Connect();

                m_TagTable = new Hashtable(1023);

                m_ReaderAPI.Events.NotifyInventoryStartEvent = true;
                m_ReaderAPI.Events.NotifyInventoryStopEvent = true;
                m_ReaderAPI.Events.NotifyAccessStartEvent = true;
                m_ReaderAPI.Events.NotifyAccessStopEvent = true;
                m_ReaderAPI.Events.NotifyAntennaEvent = true;
                m_ReaderAPI.Events.NotifyBufferFullEvent = true;
                m_ReaderAPI.Events.NotifyBufferFullWarningEvent = true;
                m_ReaderAPI.Events.NotifyReaderExceptionEvent = true;
                m_ReaderAPI.Events.NotifyReaderDisconnectEvent = true;
                m_ReaderAPI.Events.NotifyHandheldTriggerEvent = true;
                m_ReaderAPI.Events.StatusNotify += new Events.StatusNotifyHandler(Events_StatusNotify);
                m_ReaderAPI.Events.ReadNotify += new Events.ReadNotifyHandler(Events_ReadNotify);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error conexión localhost", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
        }

        /// <summary>
        /// write tag
        /// </summary>
        /// <param name="TagID"></param>
        /// <param name="newTagID"></param>
        public void changeEPC(string TagID, string newTagID)
        {
            //m_ReaderAPI.Actions.TagAccess.WriteTagIDWait(

            ushort[] antennaList = new ushort[1] { 1 };
            //OPERATION_QUALIFER[] opList = new OPERATION_QUALIFER[1] { OPERATION_QUALIFER. };
            AntennaInfo antennaInfo = new AntennaInfo(antennaList/*, opList*/);
            TagAccess.WriteSpecificFieldAccessParams twriterparam = new TagAccess.WriteSpecificFieldAccessParams();
            byte[] writeData = new byte[12];
            for (int index = 0; index < 12; index += 2)
            {
                writeData[index] = byte.Parse(newTagID.Substring(index * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                writeData[index + 1] = byte.Parse(newTagID.Substring((index + 1) * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
            }
            twriterparam.WriteData = writeData;
            twriterparam.WriteDataLength = 12;
            m_ReaderAPI.Actions.TagAccess.WriteTagIDWait(TagID, twriterparam, antennaInfo);
        }

        private void Events_StatusNotify(object sender, Events.StatusEventArgs e)
        {
            Events.StatusEventData eventData = e.StatusEventData;

            if (e.StatusEventData.StatusEventType == Symbol.RFID3.Events.STATUS_EVENT_TYPE.HANDHELD_TRIGGER_EVENT && isTriggerActive)
            {
                TriggerInfo triggerInfo = new TriggerInfo();
                triggerInfo.EnableTagEventReport = true;
                
                if (eventData.HandheldTriggerEventData.HandheldTriggerEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_PRESSED &&
                    triggerInfo.StartTrigger.Type == START_TRIGGER_TYPE.START_TRIGGER_TYPE_IMMEDIATE)
                {
                    // Lets start the inventory upon GPI event even if the StartTrigger is configured as immediate
                    this.start();
                }
                if (eventData.HandheldTriggerEventData.HandheldTriggerEvent == HANDHELD_TRIGGER_EVENT_TYPE.HANDHELD_TRIGGER_RELEASED &&
                    triggerInfo.StopTrigger.Type == STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_IMMEDIATE)
                {
                    this.stop();
                    TriggerStopHandler();
                }
            }
        }

        private void Events_ReadNotify(object sender, Events.ReadEventArgs e)
        {
            TagData tags = e.ReadEventData.TagData;

            if (!isReading)
                return;
            
                if(!ValidTagHandler(tags.TagID))
                    return;

                if (tags.ContainsLocationInfo)
                {
                    LocationHandler(tags.LocationInfo.RelativeDistance);
                }
                bool isFound = false;
                lock (m_TagTable.SyncRoot)
                {
                    isFound = m_TagTable.ContainsKey(tags.TagID);
                }

                if (isFound)
                    return;
                
                lock (m_TagTable.SyncRoot)
                {
                    m_TagTable.Add(tags.TagID, tags.TagID);
                    MessageBeep(MB_OK);
                }    
                ReadHandler(tags.TagID);
        }
        
        public void start() {
            if (!isReading)
            {
                m_ReaderAPI.Actions.Inventory.Perform();
                isReading = true;
            }
        }

        public bool StartLocation(String currentepc) {
            ushort[] antennaList = new ushort[1] { 1 };
            OPERATION_QUALIFER[] opList = new OPERATION_QUALIFER[1] { OPERATION_QUALIFER.LOCATE_TAG };
            AntennaInfo antennaInfo = new AntennaInfo(antennaList, opList);
            try
            {
            m_ReaderAPI.Actions.TagLocationing.Perform(currentepc, antennaInfo);
            isReading = true;
            }
            catch (InvalidOperationException ioe)
            {
                //m_AppForm.notifyUser(ioe.Message, "Locate Operation");
                MessageBox.Show("Tag Invalida", "Busqueda de EPC");
                return false;
            }
            catch (OperationFailureException ofe)
            {
                //m_AppForm.notifyUser(ofe.StatusDescription, "Locate Operation");
                MessageBox.Show("Tag Invalida", "Busqueda de EPC");
                return false;
            }
            catch (InvalidUsageException iue)
            {
                //m_AppForm.notifyUser(iue.Info, "Locate Operation");
                MessageBox.Show("Tag Invalida", "Busqueda de EPC");
                return false;
            }
            catch (Exception ex)
            {
                //m_AppForm.notifyUser(ex.Message, "Locate Operation");
                MessageBox.Show("Tag Invalida", "Busqueda de EPC");
                return false;
            }
            return true;
        }

        public void StopLocation() {
            m_ReaderAPI.Actions.TagLocationing.Stop();
            isReading = false;
        }

        public void stop()
        {
            if(isReading){
                m_ReaderAPI.Actions.Inventory.Stop();                
                isReading = false;
            }
        }

        public void clear()
        {
            if (isReading)
            {
                m_ReaderAPI.Actions.Inventory.Stop();
                isReading = false;
            }
            m_TagTable.Clear();
        }

        public List<UpcInventory> fillUPCsInventory(ProductsList productlist)
        {
            String upc ="";
            UpcInventory UpcObject;
            List<UpcInventory> UpcList = new List<UpcInventory>();
            List<UpcInventory> UpcFinalList = new List<UpcInventory>();
            Dictionary<String, int> UpcIndex = new Dictionary<string, int>();

            foreach (Product prod in productlist.getAll())
            {
                UpcObject = new UpcInventory(prod.upc, prod.product_name);
                UpcIndex.Add(prod.upc, UpcList.Count);
                UpcList.Add(UpcObject);
            }

            foreach (DictionaryEntry item in m_TagTable)
            {
                upc=EpcTools.getUpc(item.Value.ToString());
                UpcList[UpcIndex[upc]].total++;
            }

            foreach (UpcInventory UpcO in UpcList)
            {
                if (UpcO.total != 0)
                    UpcFinalList.Add(UpcO);
            }
            return UpcFinalList;
        }

    }
}
