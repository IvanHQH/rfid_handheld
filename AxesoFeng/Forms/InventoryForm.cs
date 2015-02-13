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
using MobileEPC;
using System.Threading;
using System.IO;

using ReadWriteCsv;
using System.Runtime.InteropServices;
using AxesoFeng.Classes;
using AxesoFeng.Forms;

namespace AxesoFeng
{
    public partial class InventoryForm : BaseFormReader
    {
        public delegate void tdelegate();
        private Image image;

        public InventoryForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        private void startReading_Click(object sender, EventArgs e)
        {
            if(menu.rrfid.isReading)
            {
                menu.rrfid.stop();
                //startReading.Text="Leer";
                image = new Bitmap(Path.Combine(menu.myResDir, "trigger.bmp"));
                pbRead.Image= image;
                RefreshGrid(ref reportGrid);
            }
            else
            {                
                menu.rrfid.start();
                //startReading.Text = "Leyendo"; 
                image = new Bitmap(Path.Combine(menu.myResDir, "read.bmp"));
                pbRead.Image = image;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            menu.showCaptureFolio = false;
            this.Hide();
            menu.rrfid.clear();
            //startReading.Text = "Leer";
            image = new Bitmap(Path.Combine(menu.myResDir, "trigger.bmp"));
            pbRead.Image = image;
            labelLog.Text = "";
            reportGrid.DataSource = null;
            menu.rrfid.ReadHandler = delegate(String tag) { };            
            menu.rrfid.ValidTagHandler = delegate(String tag)
            {
                return true;
            };
            menu.rrfid.isTriggerActive = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            menu.rrfid.clear();
            //startReading.Text = "Leer";
            image = new Bitmap(Path.Combine(menu.myResDir, "trigger.bmp"));
            pbRead.Image = image;
            labelLog.Text = "";
            reportGrid.DataSource = null;
        }

        private void ReaderForm_GotFocus(object sender, EventArgs e)
        {
            if (messageForm == null)
                messageForm = new MessageComparison(menu);
            if (messageForm.varSave)
                this.Hide();
            menu.rrfid.ReadHandler = delegate(String tag)
            {
                labelLog.Invoke(new tdelegate(delegate()
                {
                    labelLog.Text = "Tag: " + menu.rrfid.m_TagTable.Count.ToString();
                }));
            };

            menu.rrfid.ValidTagHandler = delegate(String tag)
            {
                return menu.products.Exists(EpcTools.getUpc(tag));
            };

            menu.rrfid.TriggerStopHandler = delegate()
            {
                reportGrid.Invoke(new tdelegate(delegate()
                {
                    RefreshGrid(ref reportGrid);
                }));
            };

            WarehouseBox.Items.Clear();
            ComboboxItem item;
            foreach (Warehouse entry in menu.warehouses.collection)
            {
                item = new ComboboxItem();
                item.Text = entry.name;
                item.Value = entry.id;
                WarehouseBox.Items.Add(item);
            }

            menu.rrfid.isTriggerActive = true;
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {
            ProductTable.sortGrid(sender,e);
        }

        private void Comparar_Click(object sender, EventArgs e)
        {
            if (WarehouseBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un almacén", "Orden de Salida");
                return;
            }
            else
                CompareTo((WarehouseBox.SelectedItem as ComboboxItem).Value.ToString(), 1);
        }

    }
}