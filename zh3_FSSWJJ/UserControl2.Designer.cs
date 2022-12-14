namespace zh3_FSSWJJ
{
    partial class UserControl2
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
            this.components = new System.ComponentModel.Container();
            this.textBox_stud = new System.Windows.Forms.TextBox();
            this.listBox_stud = new System.Windows.Forms.ListBox();
            this.Keresés = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_stud
            // 
            this.textBox_stud.Location = new System.Drawing.Point(21, 184);
            this.textBox_stud.Name = "textBox_stud";
            this.textBox_stud.Size = new System.Drawing.Size(100, 23);
            this.textBox_stud.TabIndex = 1;
            this.textBox_stud.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_stud_Validating);
            this.textBox_stud.Validated += new System.EventHandler(this.textBox_stud_Validated);
            // 
            // listBox_stud
            // 
            this.listBox_stud.FormattingEnabled = true;
            this.listBox_stud.ItemHeight = 15;
            this.listBox_stud.Location = new System.Drawing.Point(21, 213);
            this.listBox_stud.Name = "listBox_stud";
            this.listBox_stud.Size = new System.Drawing.Size(120, 94);
            this.listBox_stud.TabIndex = 2;
            this.listBox_stud.SelectedIndexChanged += new System.EventHandler(this.listBox_stud_SelectedIndexChanged);
            // 
            // Keresés
            // 
            this.Keresés.Location = new System.Drawing.Point(37, 141);
            this.Keresés.Name = "Keresés";
            this.Keresés.Size = new System.Drawing.Size(75, 23);
            this.Keresés.TabIndex = 3;
            this.Keresés.Text = "Keresés";
            this.Keresés.UseVisualStyleBackColor = true;
            this.Keresés.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(353, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(zh3_FSSWJJ.Models.Student);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Keresés);
            this.Controls.Add(this.listBox_stud);
            this.Controls.Add(this.textBox_stud);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(551, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_stud;
        private ListBox listBox_stud;
        private Button Keresés;
        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private ErrorProvider errorProvider1;
    }
}
