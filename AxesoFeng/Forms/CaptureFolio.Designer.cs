namespace AxesoFeng.Forms
{
    partial class CaptureFolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureFolio));
            this.folioLbl = new System.Windows.Forms.Label();
            this.FolioBox = new System.Windows.Forms.TextBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // folioLbl
            // 
            this.folioLbl.Location = new System.Drawing.Point(3, 20);
            this.folioLbl.Name = "folioLbl";
            this.folioLbl.Size = new System.Drawing.Size(61, 20);
            this.folioLbl.Text = "Folio:";
            // 
            // FolioBox
            // 
            this.FolioBox.Location = new System.Drawing.Point(3, 43);
            this.FolioBox.Name = "FolioBox";
            this.FolioBox.Size = new System.Drawing.Size(234, 21);
            this.FolioBox.TabIndex = 5;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 70);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(44, 70);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(35, 25);
            this.pbNext.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CaptureFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.folioLbl);
            this.Controls.Add(this.FolioBox);
            this.Name = "CaptureFolio";
            this.Text = "Captura Folio";
            this.Load += new System.EventHandler(this.CaptureDataForm_Load);
            this.GotFocus += new System.EventHandler(this.CaptureFolio_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label folioLbl;
        private System.Windows.Forms.TextBox FolioBox;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbNext;
    }
}