using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MobileEPC;
using AxesoFeng.Classes;
using AxesoFeng.Forms;
using System.IO;

namespace AxesoFeng
{
    public partial class OrderExitForm : BaseFormReader
    {
        public delegate void tdelegate();
        private Image image;

        public OrderExitForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
            switch ((Global.Version)menu.configData.version)
            {
                case Global.Version.ISCAM:
                case Global.Version.INVENTORY_PLACE:
                    break;
                case Global.Version.INVENTORY:
                    WarehouseBox.Visible = false;
                    break;
            }
            WarehouseBox.Items.Clear();
            ComboboxItem item;
            foreach (Warehouse entry in menu.warehouses.collection)
            {
                item = new ComboboxItem();
                item.Text = entry.name;
                item.Value = entry.id;
                WarehouseBox.Items.Add(item);
            }
            messageForm = new MessageComparison(menu);
            folioForm = new ListAssetsForm(menu);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            labelLog.Text = "";
            menu.showCaptureFolio = false;
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            labelLog.Text = "";
            menu.rrfid.clear();
            reportGrid.DataSource = null;
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {
            ProductTable.sortGrid(sender, e);
        }

        private void OrderWarehouseForm_GotFocus(object sender, EventArgs e)
        {
            //if (messageForm == null)
            //    messageForm = new MessageComparison(menu);
            if (messageForm.saveDiff == true)
            {
                menu.showCaptureFolio = false;
                messageForm.saveDiff = false;
                this.Hide();
            }
            if (pushComparison == false)
            {
                menu.rrfid.clear();
                reportGrid.DataSource = null;
            }
            pushComparison = false; 
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

            menu.rrfid.isTriggerActive = true;
        }

        private void compararButton_Click(object sender, EventArgs e)
        {
            pushComparison = true;
            if (WarehouseBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un almacén", "Orden de Salida");
                return;
            }
            else
                CompareTo((WarehouseBox.SelectedItem as ComboboxItem).Value.ToString(),2);
        }

        private void OrderExitForm_Load(object sender, EventArgs e)
        {

        }

        private void startReading_Click(object sender, EventArgs e)
        {
            if (menu.rrfid.isReading)
            {
                menu.rrfid.stop();
                //startReading.Text = "Leer";
                image = new Bitmap(Path.Combine(menu.myResDir, "trigger.bmp"));
                pbRead.Image = image;
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

        private void pbFolio_Click(object sender, EventArgs e)
        {
            folioForm.Show();
        }

    }
}