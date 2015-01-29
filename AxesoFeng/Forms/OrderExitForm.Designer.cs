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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.reportGrid = new System.Windows.Forms.DataGrid();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.compararButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.Location = new System.Drawing.Point(4, 4);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(233, 22);
            this.WarehouseBox.TabIndex = 0;
            // 
            // reportGrid
            // 
            this.reportGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportGrid.Location = new System.Drawing.Point(4, 33);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.Size = new System.Drawing.Size(233, 115);
            this.reportGrid.TabIndex = 1;
            this.reportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportGrid_MouseDown);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(66, 154);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(52, 20);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Limpiar";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(124, 154);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(64, 20);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // compararButton
            // 
            this.compararButton.Location = new System.Drawing.Point(194, 154);
            this.compararButton.Name = "compararButton";
            this.compararButton.Size = new System.Drawing.Size(43, 20);
            this.compararButton.TabIndex = 5;
            this.compararButton.Text = "Comp";
            this.compararButton.Click += new System.EventHandler(this.compararButton_Click);
            // 
            // OrderExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.compararButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.WarehouseBox);
            this.Menu = this.mainMenu1;
            this.Name = "OrderExitForm";
            this.Text = "Orden de Salida";
            this.GotFocus += new System.EventHandler(this.OrderWarehouseForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox WarehouseBox;
        private System.Windows.Forms.DataGrid reportGrid;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button compararButton;
    }
}