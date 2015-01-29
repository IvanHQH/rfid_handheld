using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MobileEPC;

namespace AxesoFeng
{
    public partial class UPCSearchForm : BaseForm
    {
        public delegate void tdelegate();
        public delegate String tdelegate1();
        private MenuForm menu;
        public UPCSearchForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
        }

        public void fillProduct(String upc,String product)
        {
            UPCLabel.Text = upc;
            ProductLabel.Text = product;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.rrfid.clear();
            TagsLabel.Text = "Tags: 0";
            menu.rrfid.ReadHandler = delegate(String tag) { };

            menu.rrfid.ValidTagHandler = delegate(String tag)
            {
                return true;
            };
            menu.rrfid.isTriggerActive = false;
        }

        private void UPCSearchForm_GotFocus(object sender, EventArgs e)
        {
            EPCList.Items.Clear();
            menu.rrfid.ReadHandler = delegate(String tag)
            {
                TagsLabel.Invoke(new tdelegate(delegate()
                {
                    TagsLabel.Text = "Tag: " + menu.rrfid.m_TagTable.Count.ToString();
                    EPCList.Items.Add(tag);
                }));
            };

            menu.rrfid.ValidTagHandler = delegate(String tag)
            {
                return EpcTools.getUpc(tag) == UPCLabel.Invoke(new tdelegate1(delegate()
                {
                    return UPCLabel.Text;
                })).ToString();
                
                //return true;
            };

            menu.rrfid.isTriggerActive = true;
        }

        private void EPCList_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu.locate.LoadEPC(EPCList.GetItemText(EPCList.SelectedItem));
            //menu.locate.Show();
            /*menu.locate.Invoke(new Delegate(delegate() {
                menu.locate.Controls.
            }));*/
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            menu.rrfid.stop();
            String folder = @"\rfiddata";
            String timestamp = DateTime.Now.ToFileTime().ToString();
            String pathepc = @"\rfiddata\prod"+ UPCLabel.Text + "t" + timestamp + ".csv";
            menu.products.saveEPCs(menu.rrfid, folder, pathepc);
            menu.rrfid.clear();
            MessageBox.Show("Se guardaron los epcs del producto con exito","Detalle");
        }
    }
}