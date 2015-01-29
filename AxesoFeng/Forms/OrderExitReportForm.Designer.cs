namespace AxesoFeng
{
    partial class OrderExitReportForm
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
            this.ReportBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // ReportBox
            // 
            this.ReportBox.Location = new System.Drawing.Point(4, 4);
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.Size = new System.Drawing.Size(220, 22);
            this.ReportBox.TabIndex = 0;
            this.ReportBox.SelectedIndexChanged += new System.EventHandler(this.ReportBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(130, 29);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 20);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportGrid
            // 
            this.reportGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportGrid.Location = new System.Drawing.Point(4, 54);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.Size = new System.Drawing.Size(220, 126);
            this.reportGrid.TabIndex = 2;
            this.reportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportGrid_MouseDown);
            // 
            // OrderExitReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReportBox);
            this.Menu = this.mainMenu1;
            this.Name = "OrderExitReportForm";
            this.Text = "Reporte de Salida";
            this.Load += new System.EventHandler(this.OrderExitReport_Load);
            this.GotFocus += new System.EventHandler(this.OrderExitReportForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ReportBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGrid reportGrid;
    }
}