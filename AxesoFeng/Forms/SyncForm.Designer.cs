namespace AxesoFeng
{
    partial class SyncForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.Text = "Sincronizando";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.InventoryLabel.Location = new System.Drawing.Point(12, 41);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(206, 29);
            this.InventoryLabel.Text = "0 Entradas";
            // 
            // OrderLabel
            // 
            this.OrderLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.OrderLabel.Location = new System.Drawing.Point(12, 70);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(206, 29);
            this.OrderLabel.Text = "0 Salidas";
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.label1);
            this.Name = "SyncForm";
            this.Text = "Sincronizando";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label OrderLabel;
    }
}