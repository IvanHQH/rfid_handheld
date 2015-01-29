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

namespace AxesoFeng
{
    public partial class OrderExitForm : BaseFormReader
    {
        public delegate void tdelegate();

        public OrderExitForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            menu.showCaptureFolio = false;
            this.Hide();
        }

        //private void RefreshGrid()
        //{
        //    ProductTable table = new ProductTable();
        //    foreach (UpcInventory item in menu.rrfid.fillUPCsInventory(menu.products))
        //    {
        //        table.addRow(item.upc,item.name,item.total.ToString());
        //    }
        //    dataView = new DataView(table);
        //    reportGrid.DataSource = dataView;
        //    reportGrid.TableStyles.Clear();
        //    reportGrid.TableStyles.Add(table.getStyle());
        //}

        private void ClearButton_Click(object sender, EventArgs e)
        {
            menu.rrfid.clear();
            reportGrid.DataSource = null;
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {
            ProductTable.sortGrid(sender, e);
        }

        private void OrderWarehouseForm_GotFocus(object sender, EventArgs e)
        {
            if (messageForm == null)
                messageForm = new MessageComparison(menu);

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

            WarehouseBox.Items.Clear();
            ComboboxItem item;
            foreach (Warehouse entry in menu.warehouses.collection)
            {
                item = new ComboboxItem();
                item.Text = entry.name;
                item.Value = entry.id;
                WarehouseBox.Items.Add(item);
            }
        }

        private void compararButton_Click(object sender, EventArgs e)
        {
            if (WarehouseBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un almacén", "Orden de Salida");
                return;
            }
            else
                CompareTo((WarehouseBox.SelectedItem as ComboboxItem).Value.ToString());
        }

    }
}