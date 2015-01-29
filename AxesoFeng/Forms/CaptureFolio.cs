using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxesoFeng.Forms
{
    public partial class CaptureFolio : BaseForm
    {
        private MenuForm menu;
        private OrderExitForm readerLoading;
        private InventoryForm readerUnloading;
        private MenuForm.typeFolio type;
        
        public CaptureFolio(MenuForm form,MenuForm.typeFolio type)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
            this.type = type;
        }

        private void CaptureDataForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchEPCButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (FolioBox.TextLength != 0)
            {
                if (type == MenuForm.typeFolio.unloading)
                    readerUnloading.Show(FolioBox.Text);
                else
                    readerLoading.Show(FolioBox.Text);
            }
            else MessageBox.Show("Indique un folio", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CaptureFolio_GotFocus(object sender, EventArgs e)
        {
            if (type == MenuForm.typeFolio.unloading)
            {
                if (readerUnloading == null)
                    readerUnloading = new InventoryForm(menu);
            }
            else
            {
                if (readerLoading == null)
                    readerLoading = new OrderExitForm(menu);
            }
            if (menu.showCaptureFolio == false)
            {
                menu.showCaptureFolio = true;
                this.Hide();
            }
        }
    }
}