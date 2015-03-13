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
            this.type = type;
            switch ((Global.Version)menu.configData.version)
            {
                case Global.Version.ISCAM:
                    setColors(menu.configData);
                    break;
                case Global.Version.INVENTORY_PLACE:
                case Global.Version.INVENTORY:
                    InitReadersForm();
                    FolioBox.Text = "0";
                    break;
            }
        }

        public CaptureFolio(MenuForm form)
        {
            InitializeComponent();
            menu = form;
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
                NextForm();
            else MessageBox.Show("Indique un folio", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
        }

        public void NextForm()
        {
            if (type == MenuForm.typeFolio.unloading)
                readerUnloading.Show(FolioBox.Text);
            else
                readerLoading.Show(FolioBox.Text);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CaptureFolio_GotFocus(object sender, EventArgs e)
        {
            InitReadersForm();
        }

        private void InitReadersForm()
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