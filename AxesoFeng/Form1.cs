using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Symbol.RFID3;
using System.Threading;
using MobileEPC;

namespace AxesoFeng
{
    public partial class Form1 : Form
    {
        public delegate void AddListItem(TagData tags);
        public AddListItem myDelegate;
        bool isReading = false;
        internal RFIDReader m_ReaderAPI;
        internal bool m_IsConnected = false;
        internal int totalTagCount = 0;
        public Form1()
        {
            InitializeComponent();
            m_ReaderAPI = new RFIDReader("localhost", 5084, 0);
            m_ReaderAPI.Connect();
            m_IsConnected = true;

            m_ReaderAPI.Events.NotifyInventoryStartEvent = true;
            m_ReaderAPI.Events.NotifyInventoryStopEvent = true;
            m_ReaderAPI.Events.NotifyAccessStartEvent = true;
            m_ReaderAPI.Events.NotifyAccessStopEvent = true;
            m_ReaderAPI.Events.NotifyAntennaEvent = true;
            m_ReaderAPI.Events.NotifyBufferFullEvent = true;
            m_ReaderAPI.Events.NotifyBufferFullWarningEvent = true;
            m_ReaderAPI.Events.NotifyReaderExceptionEvent = true;
            m_ReaderAPI.Events.NotifyReaderDisconnectEvent = true;
            m_ReaderAPI.Events.StatusNotify += new Events.StatusNotifyHandler(Events_StatusNotify);
            m_ReaderAPI.Events.ReadNotify += new Events.ReadNotifyHandler(Events_ReadNotify);
            myDelegate = new AddListItem(addTag);

            labelLog.Text = "Probando " + EpcTools.getUpc("E20068060000000000000000");
        }

        private void startReading_Click(object sender, EventArgs e)
        {
            isReading=(isReading?false:true);
            startReading.Text = (isReading ? "Leyendo" : "Leer");
            if (isReading){
                m_ReaderAPI.Actions.Inventory.Perform();
            }
            else {
                m_ReaderAPI.Actions.Inventory.Stop();
            }
        }

        private void Events_StatusNotify(object sender, Events.StatusEventArgs e)
        {
            /*m_IsConnected = m_RfidReader.IsConnected;
            m_EventSignalledCallBack(e);
            if (e.StatusEventData.StatusEventType == Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT || e.StatusEventData.StatusEventType == Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT)
            {
                TagData[] tagData = m_RfidReader.Actions.GetReadTags(1000);
                if (tagData != null)
                {
                    for (uint nIndex = 0; nIndex < tagData.Length; nIndex++)
                        m_TagArrivedCallBack(tagData[nIndex]);
                }
            }*/
            //totalTagCount++;
            //labelLog.Text = "Tags" + totalTagCount.ToString();
            //this.Invoke(myDelegate);
        }

        private void Events_ReadNotify(object sender, Events.ReadEventArgs e)
        {
            this.Invoke(myDelegate, new object[] {e.ReadEventData.TagData });
        }

        private void addTag(TagData tags) {
            totalTagCount++;
            //EpcTools testepc = new EpcTools(tags.TagID);
            labelLog.Text = "Tags" + totalTagCount.ToString() + " \n " + tags.TagID/*testepc.getUpc()*/;
        }
    }
}