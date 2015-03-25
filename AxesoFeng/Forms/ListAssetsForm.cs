using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxesoFeng.Forms;
using AxesoFeng.Classes;

namespace AxesoFeng
{
    public partial class ListAssetsForm : BaseFormReader
    {
        public ListAssetsForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ListAssetsForm_GotFocus(object sender, EventArgs e)
        {
            ProductTable table = new ProductTable();
            FolioOrder folio = new FolioOrder(menu.configData.url);
            RespFolio respFolio = folio.GETServer(this.folio);
            foreach (RespFolio.Products prod in respFolio.products)
            {
                table.addRow(prod.upc,prod.name,prod.quantity.ToString());
            }
            DataView view = new DataView(table);
            reportGrid.DataSource = view;
            reportGrid.TableStyles.Clear();
            reportGrid.TableStyles.Add(table.getStyle());  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}