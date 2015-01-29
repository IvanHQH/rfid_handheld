namespace AxesoFeng
{
    partial class InventoryForm
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
            this.startReading = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.reportGrid = new System.Windows.Forms.DataGrid();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.compararButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startReading
            // 
            this.startReading.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.startReading.Location = new System.Drawing.Point(3, 146);
            this.startReading.Name = "startReading";
            this.startReading.Size = new System.Drawing.Size(44, 24);
            this.startReading.TabIndex = 1;
            this.startReading.Text = "Leer";
            this.startReading.Click += new System.EventHandler(this.startReading_Click);
            // 
            // labelLog
            // 
            this.labelLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLog.Location = new System.Drawing.Point(3, 173);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(74, 24);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ExitButton.Location = new System.Drawing.Point(106, 146);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(54, 24);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ClearButton.Location = new System.Drawing.Point(53, 146);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(47, 24);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Limpiar";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // reportGrid
            // 
            this.reportGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportGrid.Location = new System.Drawing.Point(3, 31);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.Size = new System.Drawing.Size(224, 110);
            this.reportGrid.TabIndex = 8;
            this.reportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reportGrid_MouseDown);
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.Location = new System.Drawing.Point(3, 3);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(226, 22);
            this.WarehouseBox.TabIndex = 10;
            // 
            // compararButton
            // 
            this.compararButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.compararButton.Location = new System.Drawing.Point(166, 146);
            this.compararButton.Name = "compararButton";
            this.compararButton.Size = new System.Drawing.Size(61, 24);
            this.compararButton.TabIndex = 12;
            this.compararButton.Text = "Comparar";
            this.compararButton.Click += new System.EventHandler(this.Comparar_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.compararButton);
            this.Controls.Add(this.WarehouseBox);
            this.Controls.Add(this.reportGrid);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.startReading);
            this.Menu = this.mainMenu1;
            this.Name = "InventoryForm";
            this.Text = "Control";
            this.GotFocus += new System.EventHandler(this.ReaderForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startReading;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGrid reportGrid;
        private System.Windows.Forms.ComboBox WarehouseBox;
        private System.Windows.Forms.Button compararButton;
    }
}

