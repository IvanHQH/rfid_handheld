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
using System.IO;
using System.Net;

namespace AxesoFeng
{
    public partial class ListAssetsForm : BaseFormReader
    {
        public bool firstFocus;

        public ListAssetsForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        public void setFolio(string folio)
        {
            this.folio = folio;
        }

        private void reportGrid_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ListAssetsForm_GotFocus(object sender, EventArgs e)
        {
            if (firstFocus)
            {
                firstFocus = false;
                ProductTable table = new ProductTable();
                FolioOrder folio = new FolioOrder(menu);
                RespFolio respFolio = folio.getFolioFtp(menu.ftpConfig.server_name, 
                    menu.ftpConfig.user_name, menu.ftpConfig.user_password,this.folio);
                if (respFolio != null)
                {
                    foreach (RespFolio.Products prod in respFolio.products)
                        table.addRow(prod.upc, prod.name, prod.quantity.ToString());
                    DataView view = new DataView(table);
                    reportGrid.DataSource = view;
                    reportGrid.TableStyles.Clear();
                    reportGrid.TableStyles.Add(table.getStyle());
                }
                else MessageBox.Show("No se encontro el archivo");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            firstFocus = true;
            this.Hide();
        }
    }
}