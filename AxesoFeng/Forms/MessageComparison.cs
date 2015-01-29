using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ReadWriteCsv;

namespace AxesoFeng.Forms
{
    public partial class MessageComparison : BaseForm
    {
        private MenuForm menu;
        //private String nameFile;
        private String folio;
        private String valueWarehouse;

        public MessageComparison(MenuForm form)
        {            
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        public void fillMessages(List<String> messages,String valueWarehouse, String folio)
        {
            //this.nameFile = nameFile;
            this.valueWarehouse = valueWarehouse;
            this.folio = folio;
            messagesListview.Items.Clear();
            foreach (String message in messages)
                messagesListview.Items.Add(new ListViewItem(message));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            menu.showCaptureFolio = false;
            this.Hide();
        }

        private void messagesListview_GotFocus(object sender, EventArgs e)
        {

        }

        private void messagesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in messagesListview.Items)
            {
                if (item.Selected)
                {
                    MessageBox.Show(item.Text);
                    break;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        { 
            Save(valueWarehouse,folio);
        }

        public void Save(String valueWarehouse,String folio)
        {
            this.valueWarehouse = valueWarehouse;
            this.folio = folio;

            menu.rrfid.stop();
            labelLog.Text = "Guardando";
            String folder = "\\rfiddata";
            String path;
            DateTime timestamp = DateTime.Now;
            path = NameFile(TypeFile.epc, valueWarehouse,timestamp,false);
            menu.products.saveEPCs(menu.rrfid, folder, path);
            path = NameFile(TypeFile.upc, valueWarehouse,timestamp,false);
            menu.products.saveUPCs(menu.rrfid, folder, path);
            menu.rrfid.clear();
            //nombre a archivo mensajes
            path = NameFile(TypeFile.upc, valueWarehouse, timestamp, true);
            SaveMessage(folder, path);
            labelLog.Text = "";
            MessageBox.Show("Orden guardada");
            menu.showCaptureFolio = false;
            this.Hide();
        }

        private void SaveMessage(string folder, string path)
        {
            Directory.CreateDirectory(folder);

            using (CsvFileWriter writer = new CsvFileWriter(path))
            {
                //foreach (UpcInventory item in reader.fillUPCsInventory(this))
                foreach(ListViewItem item in messagesListview.Items)
                {
                    writer.WriteLine(item.Text);
                }
            }
        }

        protected String NameFile(TypeFile type, String valueWarehouse,DateTime timestamp,Boolean message)
        {
            
            String dataName = menu.idCustomer.ToString();
            dataName += "_" + valueWarehouse;//(WarehouseBox.SelectedItem as ComboboxItem).Value.ToString();
            dataName += "_" + folio;
            dataName += "_" + FormatDateTime(timestamp);
            String path;
            if (message)
                path = "\\rfiddata\\message_" + dataName + ".csv";
            else
            {
                if (TypeFile.epc == type)
                    path = "\\rfiddata\\iepcs_" + dataName + ".csv";
                else
                    path = "\\rfiddata\\iupcs_" + dataName + ".csv";
            }
            return path;
        }
    }
}