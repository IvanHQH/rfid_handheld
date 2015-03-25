namespace AxesoFeng.Forms
{
    partial class MessageComparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageComparison));
            this.messagesListview = new System.Windows.Forms.ListView();
            this.labelLog = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // messagesListview
            // 
            this.messagesListview.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.messagesListview.Location = new System.Drawing.Point(4, 4);
            this.messagesListview.Name = "messagesListview";
            this.messagesListview.Size = new System.Drawing.Size(224, 186);
            this.messagesListview.TabIndex = 6;
            this.messagesListview.View = System.Windows.Forms.View.List;
            this.messagesListview.SelectedIndexChanged += new System.EventHandler(this.messagesListview_SelectedIndexChanged);
            this.messagesListview.GotFocus += new System.EventHandler(this.messagesListview_GotFocus);
            // 
            // labelLog
            // 
            this.labelLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLog.Location = new System.Drawing.Point(3, 193);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(74, 24);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 192);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(44, 192);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(35, 25);
            this.pbSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MessageComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.messagesListview);
            this.Name = "MessageComparison";
            this.Text = "Comparación";
            this.GotFocus += new System.EventHandler(this.MessageComparison_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView messagesListview;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSave;
    }
}