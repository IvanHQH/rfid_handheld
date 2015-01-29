using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace AxesoFeng
{
    public partial class BaseForm : Form
    {
        public enum TypeFile { epc = 1, upc = 2 }

        public void setColors(Config configdata)
        {
            this.BackColor = Color.Black;
            foreach (Control control in this.Controls){
                switch(control.GetType().ToString()){
                    case "System.Windows.Forms.Button":
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    break;
                    case "System.Windows.Forms.Label":
                        control.ForeColor = Color.White;
                    break;
                    case "System.Windows.Forms.DataGrid":
                        DataGrid tempGrid=(DataGrid)control;
                        tempGrid.HeaderBackColor = Color.White;
                        tempGrid.BackgroundColor = Color.White;
                    break;
                }
            }
        }

        /// <summary>
        /// Format 14-12-30-183035
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public string FormatDateTime(DateTime dateTime)
        {
            string result = "";
            result = dateTime.Year.ToString().Substring(2, 2);
            result += "-" + dateTime.Month.ToString("00");
            result += "-" + dateTime.Day.ToString("00");
            result += "-" + dateTime.Hour.ToString("00");
            result += dateTime.Minute.ToString("00");
            result += dateTime.Second.ToString("00");
            return result;
        }

    }
}
