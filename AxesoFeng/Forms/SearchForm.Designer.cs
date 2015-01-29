namespace AxesoFeng
{
    partial class SearchForm
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
            this.productBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EPCBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchEPCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productBox
            // 
            this.productBox.Location = new System.Drawing.Point(4, 23);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(233, 22);
            this.productBox.TabIndex = 0;
            this.productBox.SelectedIndexChanged += new System.EventHandler(this.productBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(120, 124);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 33);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Regresar";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EPCBox
            // 
            this.EPCBox.Location = new System.Drawing.Point(71, 56);
            this.EPCBox.Name = "EPCBox";
            this.EPCBox.Size = new System.Drawing.Size(166, 21);
            this.EPCBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Por producto:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.Text = "Por EPC:";
            // 
            // SearchEPCButton
            // 
            this.SearchEPCButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.SearchEPCButton.Location = new System.Drawing.Point(120, 83);
            this.SearchEPCButton.Name = "SearchEPCButton";
            this.SearchEPCButton.Size = new System.Drawing.Size(117, 35);
            this.SearchEPCButton.TabIndex = 3;
            this.SearchEPCButton.Text = "Buscar EPC";
            this.SearchEPCButton.Click += new System.EventHandler(this.SearchEPCButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.SearchEPCButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EPCBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.productBox);
            this.Menu = this.mainMenu1;
            this.Name = "SearchForm";
            this.Text = "Buscar";
            this.GotFocus += new System.EventHandler(this.SearchForm_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox EPCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchEPCButton;
    }
}