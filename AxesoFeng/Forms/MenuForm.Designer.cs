namespace AxesoFeng
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.OrderExitReportPicture = new System.Windows.Forms.PictureBox();
            this.OrderExitPicture = new System.Windows.Forms.PictureBox();
            this.SyncPicture = new System.Windows.Forms.PictureBox();
            this.SearchPicture = new System.Windows.Forms.PictureBox();
            this.ReportPicture = new System.Windows.Forms.PictureBox();
            this.ReaderPicture = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(231, 209);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(35, 25);
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pbClear
            // 
            this.pbClear.Image = ((System.Drawing.Image)(resources.GetObject("pbClear.Image")));
            this.pbClear.Location = new System.Drawing.Point(272, 209);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(35, 25);
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // ExitPicture
            // 
            this.ExitPicture.Image = ((System.Drawing.Image)(resources.GetObject("ExitPicture.Image")));
            this.ExitPicture.Location = new System.Drawing.Point(272, 18);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(35, 24);
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(-9, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(120, 60);
            // 
            // OrderExitReportPicture
            // 
            this.OrderExitReportPicture.Location = new System.Drawing.Point(109, 143);
            this.OrderExitReportPicture.Name = "OrderExitReportPicture";
            this.OrderExitReportPicture.Size = new System.Drawing.Size(96, 60);
            this.OrderExitReportPicture.Click += new System.EventHandler(this.OrderExitReportPicture_Click);
            // 
            // OrderExitPicture
            // 
            this.OrderExitPicture.Location = new System.Drawing.Point(7, 143);
            this.OrderExitPicture.Name = "OrderExitPicture";
            this.OrderExitPicture.Size = new System.Drawing.Size(96, 60);
            this.OrderExitPicture.Click += new System.EventHandler(this.OrderExitPicture_Click);
            // 
            // SyncPicture
            // 
            this.SyncPicture.Location = new System.Drawing.Point(211, 143);
            this.SyncPicture.Name = "SyncPicture";
            this.SyncPicture.Size = new System.Drawing.Size(96, 60);
            this.SyncPicture.Click += new System.EventHandler(this.SyncPicture_Click);
            // 
            // SearchPicture
            // 
            this.SearchPicture.Location = new System.Drawing.Point(211, 74);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.Size = new System.Drawing.Size(96, 60);
            this.SearchPicture.Click += new System.EventHandler(this.SearchPicture_Click);
            // 
            // ReportPicture
            // 
            this.ReportPicture.Location = new System.Drawing.Point(109, 74);
            this.ReportPicture.Name = "ReportPicture";
            this.ReportPicture.Size = new System.Drawing.Size(96, 60);
            this.ReportPicture.Click += new System.EventHandler(this.ReportPicture_Click);
            // 
            // ReaderPicture
            // 
            this.ReaderPicture.Location = new System.Drawing.Point(7, 74);
            this.ReaderPicture.Name = "ReaderPicture";
            this.ReaderPicture.Size = new System.Drawing.Size(96, 60);
            this.ReaderPicture.Click += new System.EventHandler(this.ReaderPicture_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.ExitPicture);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.OrderExitReportPicture);
            this.Controls.Add(this.OrderExitPicture);
            this.Controls.Add(this.SyncPicture);
            this.Controls.Add(this.SearchPicture);
            this.Controls.Add(this.ReportPicture);
            this.Controls.Add(this.ReaderPicture);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.GotFocus += new System.EventHandler(this.MenuForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ReaderPicture;
        private System.Windows.Forms.PictureBox ReportPicture;
        private System.Windows.Forms.PictureBox SyncPicture;
        private System.Windows.Forms.PictureBox SearchPicture;
        private System.Windows.Forms.PictureBox OrderExitReportPicture;
        private System.Windows.Forms.PictureBox OrderExitPicture;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.PictureBox ExitPicture;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pbEdit;
    }
}