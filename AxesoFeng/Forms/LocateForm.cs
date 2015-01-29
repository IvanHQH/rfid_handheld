using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.RFID3;

namespace AxesoFeng
{
    public partial class LocateForm : BaseForm
    {
        public delegate String tdelegate();
        public delegate void tdelegate1();
        private String currentepc="";
        internal MotoProgressBar Locate_PB = null;
        internal int lastLocatedTagTimeStamp;
        private MenuForm menu;
        public LocateForm(MenuForm form)
        {
            InitializeComponent();
            menu = form;
            setColors(menu.configData);
            Locate_PB = new MotoProgressBar();

            Locate_PB.Location = new System.Drawing.Point(100, 90);
            Locate_PB.Name = "Indicator_PB";

            Locate_PB.Size = new System.Drawing.Size(40, 147);
            Locate_PB.Maximum = 100;
            Locate_PB.Minimum = 0;
            Controls.Add(this.Locate_PB);

            // Set initial value to 0
            Locate_PB.Value = 0;

            
        }

        public void LoadEPC(String epc){
            EPCLabel.Text = epc;
            currentepc = epc;

            menu.rrfid.stop();
            menu.rrfid.clear();

            menu.rrfid.ValidTagHandler = delegate(String tag)
            {
                return tag == currentepc;
            };

            menu.rrfid.LocationHandler = delegate(short relatived)
            {
                this.Invoke(new tdelegate1(delegate()
                {
                    Locate_PB.Value = relatived;
                })).ToString();
                lastLocatedTagTimeStamp = System.Environment.TickCount;
                //return true;
            };
            if (!menu.rrfid.StartLocation(currentepc))
                return;
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.rrfid.StopLocation();
        }

        private void LocateForm_GotFocus(object sender, EventArgs e)
        {
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int currentTimeStamp = System.Environment.TickCount;
            if ((currentTimeStamp - lastLocatedTagTimeStamp) > this.timer.Interval)
            {
                this.Locate_PB.Value = 0;
            }
        }
    }
}