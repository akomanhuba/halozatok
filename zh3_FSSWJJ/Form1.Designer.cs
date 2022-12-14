namespace zh3_FSSWJJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_touc1 = new System.Windows.Forms.Button();
            this.button2_touc2 = new System.Windows.Forms.Button();
            this.button3_tofrom2 = new System.Windows.Forms.Button();
            this.button4_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(403, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 459);
            this.panel1.TabIndex = 0;
            // 
            // button1_touc1
            // 
            this.button1_touc1.Location = new System.Drawing.Point(37, 67);
            this.button1_touc1.Name = "button1_touc1";
            this.button1_touc1.Size = new System.Drawing.Size(96, 101);
            this.button1_touc1.TabIndex = 1;
            this.button1_touc1.Text = "Rendelés";
            this.button1_touc1.UseVisualStyleBackColor = true;
            this.button1_touc1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_touc2
            // 
            this.button2_touc2.Location = new System.Drawing.Point(37, 200);
            this.button2_touc2.Name = "button2_touc2";
            this.button2_touc2.Size = new System.Drawing.Size(96, 101);
            this.button2_touc2.TabIndex = 2;
            this.button2_touc2.Text = "Neptun szűrés";
            this.button2_touc2.UseVisualStyleBackColor = true;
            this.button2_touc2.Click += new System.EventHandler(this.button2_touc2_Click);
            // 
            // button3_tofrom2
            // 
            this.button3_tofrom2.Location = new System.Drawing.Point(37, 333);
            this.button3_tofrom2.Name = "button3_tofrom2";
            this.button3_tofrom2.Size = new System.Drawing.Size(96, 101);
            this.button3_tofrom2.TabIndex = 3;
            this.button3_tofrom2.Text = "Adatok";
            this.button3_tofrom2.UseVisualStyleBackColor = true;
            this.button3_tofrom2.Click += new System.EventHandler(this.button3_tofrom2_Click);
            // 
            // button4_exit
            // 
            this.button4_exit.Location = new System.Drawing.Point(37, 460);
            this.button4_exit.Name = "button4_exit";
            this.button4_exit.Size = new System.Drawing.Size(96, 101);
            this.button4_exit.TabIndex = 4;
            this.button4_exit.Text = "Kilépés";
            this.button4_exit.UseVisualStyleBackColor = true;
            this.button4_exit.Click += new System.EventHandler(this.button4_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 709);
            this.Controls.Add(this.button4_exit);
            this.Controls.Add(this.button3_tofrom2);
            this.Controls.Add(this.button2_touc2);
            this.Controls.Add(this.button1_touc1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1_touc1;
        private Button button2_touc2;
        private Button button3_tofrom2;
        private Button button4_exit;
    }
}