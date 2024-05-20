namespace Otomasyon
{
    partial class UyeleriGoruntule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeleriGoruntule));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UyeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(696, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 32);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(294, 51);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 6;
            label2.Text = "Üyeleri Listele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 5;
            label1.Text = "FITNESS CENTER";
            // 
            // UyeDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UyeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UyeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UyeDGV.ColumnHeadersHeight = 30;
            UyeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UyeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UyeDGV.GridColor = Color.FromArgb(231, 229, 255);
            UyeDGV.Location = new Point(116, 155);
            UyeDGV.Name = "UyeDGV";
            UyeDGV.RowHeadersVisible = false;
            UyeDGV.Size = new Size(611, 351);
            UyeDGV.TabIndex = 41;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UyeDGV.ThemeStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            UyeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UyeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UyeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            UyeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UyeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UyeDGV.ThemeStyle.HeaderStyle.Height = 30;
            UyeDGV.ThemeStyle.ReadOnly = false;
            UyeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UyeDGV.ThemeStyle.RowsStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UyeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UyeDGV.ThemeStyle.RowsStyle.Height = 25;
            UyeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Red;
            UyeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(402, 115);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 42;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(508, 115);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 43;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(326, 517);
            button3.Name = "button3";
            button3.Size = new Size(176, 34);
            button3.TabIndex = 45;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 563);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UyeDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)UyeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView UyeDGV;
        private Button button1;
        private Button button2;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Button button3;
        private PictureBox pictureBox2;
    }
}