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

namespace AxesoFeng
{
    public partial class InventoryReportFrm : BaseForm
    {
        private MenuForm menu;
        List<string> upcFiles;

        public InventoryReportFrm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        private void Report_GotFocus(object sender, EventArgs e)
        {
            reportBox.Items.Clear();
            reportGrid.DataSource = null;
            string[] filePaths = Directory.GetFiles(@"\rfiddata");
            upcFiles = new List<string>();

            foreach (String path in filePaths){
                if (path.StartsWith("\\rfiddata\\iupc"))
                    upcFiles.Add(path);
            }
            string[] comp;
            foreach (String path1 in upcFiles)                
            {
                comp = path1.Split(new Char[] { '_' });
                try 
                {
                    switch ((Global.Version)menu.configData.version)
                    {
                        case Global.Version.ISCAM:
                            reportBox.Items.Add(comp[3] + " " +
                                //Date only whit tens 
                            Sync.FormatDateTime(comp[4]).Substring(2, comp[4].Length - 2));
                            break;
                        case Global.Version.INVENTORY_PLACE:
                        case Global.Version.INVENTORY:
                            reportBox.Items.Add(Sync.FormatDateTime(comp[4]).Substring(2, comp[4].Length - 2));
                            break;
                    }
                }
                catch (Exception exc) {
                    MessageBox.Show("Nombre del archivo sin formato correcto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    this.Hide();
                    break;
                }                
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductTable table = new ProductTable();
            if (reportBox.SelectedIndex == -1)
                return;
            String path = upcFiles[reportBox.SelectedIndex];

            using (CsvFileReader reader = new CsvFileReader(path))
            {
                CsvRow rowcsv = new CsvRow();
                while (reader.ReadRow(rowcsv))
                {
                    table.addRow(rowcsv[0],rowcsv[1],rowcsv[2]);
                }
            }
            DataView view = new DataView(table);            
            reportGrid.DataSource = view;
            reportGrid.TableStyles.Clear();
            reportGrid.TableStyles.Add(table.getStyle());            
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {
            ProductTable.sortGrid(sender, e);
        }
    }
}