namespace zh3_FSSWJJ
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ad = new System.Windows.Forms.Button();
            this.button2_vesz = new System.Windows.Forms.Button();
            this.textBox__stud = new System.Windows.Forms.TextBox();
            this.textBox__konyv = new System.Windows.Forms.TextBox();
            this.listBox__stud = new System.Windows.Forms.ListBox();
            this.listBox__konyv = new System.Windows.Forms.ListBox();
            this.listBox__rend = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_ad
            // 
            this.button_ad.Location = new System.Drawing.Point(70, 359);
            this.button_ad.Name = "button_ad";
            this.button_ad.Size = new System.Drawing.Size(75, 44);
            this.button_ad.TabIndex = 0;
            this.button_ad.Text = "+";
            this.button_ad.UseVisualStyleBackColor = true;
            this.button_ad.Click += new System.EventHandler(this.button_ad_Click);
            // 
            // button2_vesz
            // 
            this.button2_vesz.Location = new System.Drawing.Point(70, 409);
            this.button2_vesz.Name = "button2_vesz";
            this.button2_vesz.Size = new System.Drawing.Size(75, 44);
            this.button2_vesz.TabIndex = 1;
            this.button2_vesz.Text = "-";
            this.button2_vesz.UseVisualStyleBackColor = true;
            this.button2_vesz.Click += new System.EventHandler(this.button2_vesz_Click);
            // 
            // textBox__stud
            // 
            this.textBox__stud.Location = new System.Drawing.Point(54, 152);
            this.textBox__stud.Name = "textBox__stud";
            this.textBox__stud.Size = new System.Drawing.Size(100, 23);
            this.textBox__stud.TabIndex = 2;
            this.textBox__stud.TextChanged += new System.EventHandler(this.textBox__stud_TextChanged);
            // 
            // textBox__konyv
            // 
            this.textBox__konyv.Location = new System.Drawing.Point(54, 253);
            this.textBox__konyv.Name = "textBox__konyv";
            this.textBox__konyv.Size = new System.Drawing.Size(100, 23);
            this.textBox__konyv.TabIndex = 3;
            this.textBox__konyv.TextChanged += new System.EventHandler(this.textBox__konyv_TextChanged);
            // 
            // listBox__stud
            // 
            this.listBox__stud.FormattingEnabled = true;
            this.listBox__stud.ItemHeight = 15;
            this.listBox__stud.Location = new System.Drawing.Point(160, 152);
            this.listBox__stud.Name = "listBox__stud";
            this.listBox__stud.Size = new System.Drawing.Size(120, 94);
            this.listBox__stud.TabIndex = 4;
            this.listBox__stud.SelectedIndexChanged += new System.EventHandler(this.listBox__stud_SelectedIndexChanged);
            // 
            // listBox__konyv
            // 
            this.listBox__konyv.FormattingEnabled = true;
            this.listBox__konyv.ItemHeight = 15;
            this.listBox__konyv.Location = new System.Drawing.Point(160, 253);
            this.listBox__konyv.Name = "listBox__konyv";
            this.listBox__konyv.Size = new System.Drawing.Size(120, 94);
            this.listBox__konyv.TabIndex = 5;
            this.listBox__konyv.SelectedIndexChanged += new System.EventHandler(this.listBox__konyv_SelectedIndexChanged);
            // 
            // listBox__rend
            // 
            this.listBox__rend.FormattingEnabled = true;
            this.listBox__rend.ItemHeight = 15;
            this.listBox__rend.Location = new System.Drawing.Point(160, 359);
            this.listBox__rend.Name = "listBox__rend";
            this.listBox__rend.Size = new System.Drawing.Size(120, 94);
            this.listBox__rend.TabIndex = 6;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listBox__rend);
            this.Controls.Add(this.listBox__konyv);
            this.Controls.Add(this.listBox__stud);
            this.Controls.Add(this.textBox__konyv);
            this.Controls.Add(this.textBox__stud);
            this.Controls.Add(this.button2_vesz);
            this.Controls.Add(this.button_ad);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(721, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_ad;
        private Button button2_vesz;
        private TextBox textBox__stud;
        private TextBox textBox__konyv;
        private ListBox listBox__stud;
        private ListBox listBox__konyv;
        private ListBox listBox__rend;
    }
}
