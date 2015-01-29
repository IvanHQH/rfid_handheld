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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGrid();
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
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(153, 165);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 20);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // InventoryReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.reportBox);
            this.Menu = this.mainMenu1;
            this.Name = "InventoryReportFrm";
            this.Text = "Reporte";
            this.GotFocus += new System.EventHandler(this.Report_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGrid reportGrid;
    }
}