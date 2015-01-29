namespace AxesoFeng
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // startReading
            // 
            this.startReading.Location = new System.Drawing.Point(4, 4);
            this.startReading.Name = "startReading";
            this.startReading.Size = new System.Drawing.Size(71, 20);
            this.startReading.TabIndex = 1;
            this.startReading.Text = "Leer";
            this.startReading.Click += new System.EventHandler(this.startReading_Click);
            // 
            // labelLog
            // 
            this.labelLog.Location = new System.Drawing.Point(4, 27);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(233, 172);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.startReading);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startReading;
        private System.Windows.Forms.Label labelLog;
    }
}

