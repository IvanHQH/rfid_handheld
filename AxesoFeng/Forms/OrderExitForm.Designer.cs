namespace AxesoFeng
{
    partial class OrderExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderExitForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.reportGrid = new System.Windows.Forms.DataGrid();
            this.labelLog = new System.Windows.Forms.Label();
            this.pbCompare = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbRead = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.Location = new System.Drawing.Point(4, 138);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(224, 22);
            this.WarehouseBox.TabIndex = 0;
            // 
            // reportGrid
            // 
            this.reportGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportGrid.Location = new System.Drawing.Point(4, 3);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.Size = new System.Drawing.Size(224, 136);
            this.reportGrid.TabIndex = 1;
            this.reportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportGrid_MouseDown);
            // 
            // labelLog
            // 
            this.labelLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLog.Location = new System.Drawing.Point(154, 163);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(74, 20);
            // 
            // pbCompare
            // 
            this.pbCompare.Image = ((System.Drawing.Image)(resources.GetObject("pbCompare.Image")));
            this.pbCompare.Location = new System.Drawing.Point(117, 161);
            this.pbCompare.Name = "pbCompare";
            this.pbCompare.Size = new System.Drawing.Size(35, 25);
            this.pbCompare.Click += new System.EventHandler(this.compararButton_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(5, 161);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pbClear
            // 
            this.pbClear.Image = ((System.Drawing.Image)(resources.GetObject("pbClear.Image")));
            this.pbClear.Location = new System.Drawing.Point(79, 161);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(35, 25);
            this.pbClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pbRead
            // 
            this.pbRead.Image = ((System.Drawing.Image)(resources.GetObject("pbRead.Image")));
            this.pbRead.Location = new System.Drawing.Point(42, 161);
            this.pbRead.Name = "pbRead";
            this.pbRead.Size = new System.Drawing.Size(35, 25);
            this.pbRead.Click += new System.EventHandler(this.startReading_Click);
            // 
            // OrderExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbCompare);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.pbRead);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.WarehouseBox);
            this.Menu = this.mainMenu1;
            this.Name = "OrderExitForm";
            this.Text = "Orden de Salida";
            this.Load += new System.EventHandler(this.OrderExitForm_Load);
            this.GotFocus += new System.EventHandler(this.OrderWarehouseForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox WarehouseBox;
        private System.Windows.Forms.DataGrid reportGrid;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.PictureBox pbCompare;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pbRead;
    }
}