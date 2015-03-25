namespace AxesoFeng
{
    partial class UPCSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPCSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.UPCLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EPCList = new System.Windows.Forms.ListBox();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Producto:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.ProductLabel.Location = new System.Drawing.Point(4, 20);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(233, 20);
            // 
            // UPCLabel
            // 
            this.UPCLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.UPCLabel.Location = new System.Drawing.Point(88, 40);
            this.UPCLabel.Name = "UPCLabel";
            this.UPCLabel.Size = new System.Drawing.Size(100, 20);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "UPC:";
            // 
            // EPCList
            // 
            this.EPCList.Location = new System.Drawing.Point(4, 62);
            this.EPCList.Name = "EPCList";
            this.EPCList.Size = new System.Drawing.Size(222, 100);
            this.EPCList.TabIndex = 6;
            this.EPCList.SelectedIndexChanged += new System.EventHandler(this.EPCList_SelectedIndexChanged);
            // 
            // TagsLabel
            // 
            this.TagsLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TagsLabel.Location = new System.Drawing.Point(125, 173);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(100, 20);
            this.TagsLabel.Text = "Tags: 0";
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 168);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 25);
            this.pbBack.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(44, 168);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(35, 25);
            this.pbSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UPCSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.EPCList);
            this.Controls.Add(this.UPCLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.label1);
            this.Name = "UPCSearchForm";
            this.Text = "Detalle";
            this.GotFocus += new System.EventHandler(this.UPCSearchForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label UPCLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EPCList;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSave;
    }
}