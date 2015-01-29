namespace AxesoFeng.Forms
{
    partial class CaptureFolio
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
            this.NextButton = new System.Windows.Forms.Button();
            this.folioLbl = new System.Windows.Forms.Label();
            this.FolioBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.NextButton.Location = new System.Drawing.Point(120, 70);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(117, 35);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
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
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(3, 70);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CaptureFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.folioLbl);
            this.Controls.Add(this.FolioBox);
            this.Menu = this.mainMenu1;
            this.Name = "CaptureFolio";
            this.Text = "Input Folio";
            this.Load += new System.EventHandler(this.CaptureDataForm_Load);
            this.GotFocus += new System.EventHandler(this.CaptureFolio_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label folioLbl;
        private System.Windows.Forms.TextBox FolioBox;
        private System.Windows.Forms.Button ExitButton;
    }
}