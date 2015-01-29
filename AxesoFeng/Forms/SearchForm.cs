using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxesoFeng
{
    public partial class SearchForm : BaseForm
    {
        private MenuForm menu;

        public SearchForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        private void SearchForm_GotFocus(object sender, EventArgs e)
        {
            productBox.Items.Clear();
            ComboboxItem item;
            foreach (Product prod in menu.products.getAll())
            {
                item = new ComboboxItem();
                item.Text = prod.product_name;
                item.Value = prod.upc;
                productBox.Items.Add(item);
            }
        }

        private void productBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text=(productBox.SelectedItem as ComboboxItem).Value.ToString();
            menu.upcsearch.Show();
            menu.upcsearch.fillProduct((productBox.SelectedItem as ComboboxItem).Value.ToString(),(productBox.SelectedItem as ComboboxItem).Text.ToString());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchEPCButton_Click(object sender, EventArgs e)
        {
            menu.locate.LoadEPC(EPCBox.Text);
            //MenuForm.locate.Show();
        }
    }
}