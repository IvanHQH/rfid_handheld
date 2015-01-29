using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxesoFeng
{
    public partial class SyncForm : BaseForm
    {
        private MenuForm menu;

        public SyncForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        public void updateInventory(String text)
        {
            InventoryLabel.Text = text;
        }

        public void updateOrder(String text)
        {
            OrderLabel.Text = text;
        }
    }
}