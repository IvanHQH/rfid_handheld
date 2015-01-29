namespace AxesoFeng.Forms
{
    partial class MessageComparison
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.messagesListview = new System.Windows.Forms.ListView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ExitButton.Location = new System.Drawing.Point(174, 161);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(54, 24);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // messagesListview
            // 
            this.messagesListview.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.messagesListview.Location = new System.Drawing.Point(4, 4);
            this.messagesListview.Name = "messagesListview";
            this.messagesListview.Size = new System.Drawing.Size(224, 151);
            this.messagesListview.TabIndex = 6;
            this.messagesListview.View = System.Windows.Forms.View.List;
            this.messagesListview.SelectedIndexChanged += new System.EventHandler(this.messagesListview_SelectedIndexChanged);
            this.messagesListview.GotFocus += new System.EventHandler(this.messagesListview_GotFocus);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.SaveButton.Location = new System.Drawing.Point(118, 161);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 24);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // labelLog
            // 
            this.labelLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLog.Location = new System.Drawing.Point(4, 161);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(74, 24);
            // 
            // MessageComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.messagesListview);
            this.Controls.Add(this.ExitButton);
            this.Menu = this.mainMenu1;
            this.Name = "MessageComparison";
            this.Text = "Comparison Result";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView messagesListview;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label labelLog;
    }
}