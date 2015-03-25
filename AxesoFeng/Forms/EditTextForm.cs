using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxesoFeng.Classes;
using System.IO;
using Newtonsoft.Json;

namespace AxesoFeng
{
    public partial class EditTextForm : BaseFormReader
    {
        private String path;
        private bool _restart;
        public bool Restart
        {
            get { return _restart; }
        }

        public EditTextForm(MenuForm form,String path)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
            this.path = path;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            try {
                menu.configData.url = txturl.Text;
                menu.configData.id_client = int.Parse(txtIdClient.Text);
                menu.configData.version = int.Parse(txtversion.Text);
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.Write(JsonConvert.SerializeObject(menu.configData));
                }
                _restart = true;
                Hide();
            }
            catch (Exception exc) { 

            }
        }

        private void EditTextForm_GotFocus(object sender, EventArgs e)
        {
            txtIdClient.Text = menu.configData.id_client.ToString();
            txturl.Text = menu.configData.url;
            txtversion.Text = menu.configData.version.ToString();
            _restart = false;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}