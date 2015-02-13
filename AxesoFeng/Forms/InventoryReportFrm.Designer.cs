namespace AxesoFeng
{
    partial class InventoryReportFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReportFrm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.reportGrid = new System.Windows.Forms.DataGrid();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(3, 3);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(222, 22);
            this.reportBox.TabIndex = 0;
            this.reportBox.SelectedIndexChanged += new System.EventHandler(this.reportBox_SelectedIndexChanged);
            // 
            // reportGrid
            // 
            this.reportGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportGrid.Location = new System.Drawing.Point(3, 31);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.Size = new System.Drawing.Size(222, 128);
            this.reportGrid.TabIndex = 2;
            this.reportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportGrid_MouseDown);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 165);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InventoryReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.reportBox);
            this.Menu = this.mainMenu1;
            this.Name = "InventoryReportFrm";
            this.Text = "Reporte Inventario";
            this.GotFocus += new System.EventHandler(this.Report_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.DataGrid reportGrid;
        private System.Windows.Forms.PictureBox pbBack;
    }
}