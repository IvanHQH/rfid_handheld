namespace AxesoFeng
{
    partial class EditTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTextForm));
            this.lblurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.lblversion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // lblurl
            // 
            this.lblurl.Location = new System.Drawing.Point(9, 21);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(50, 20);
            this.lblurl.Text = "url";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(65, 20);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(156, 21);
            this.txturl.TabIndex = 1;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(65, 47);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(156, 21);
            this.txtIdClient.TabIndex = 3;
            // 
            // lblIdClient
            // 
            this.lblIdClient.Location = new System.Drawing.Point(9, 48);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(50, 20);
            this.lblIdClient.Text = "id client";
            // 
            // txtversion
            // 
            this.txtversion.Location = new System.Drawing.Point(65, 74);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(156, 21);
            this.txtversion.TabIndex = 6;
            // 
            // lblversion
            // 
            this.lblversion.Location = new System.Drawing.Point(9, 75);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(50, 20);
            this.lblversion.Text = "versión";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "1 1 Center Star Logistic";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(0, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "2 2 Edificio M";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(0, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "5 3 Cafe Luna";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(0, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "6 4 Plomeria Selecta";
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(186, 194);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(35, 25);
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(145, 194);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // EditTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtversion);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.lblIdClient);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurl);
            this.Name = "EditTextForm";
            this.Text = "Editar";
            this.GotFocus += new System.EventHandler(this.EditTextForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbBack;
    }
}