namespace Otomasyon
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            Periyot = new DateTimePicker();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            OdemeTb = new Guna.UI2.WinForms.Guna2TextBox();
            AdSoyadCb = new ComboBox();
            OdemeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(848, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 32);
            label3.TabIndex = 10;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(365, 41);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 9;
            label2.Text = "Ödemeler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 8;
            label1.Text = "FITNESS CENTER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(23, 254);
            label5.Name = "label5";
            label5.Size = new Size(55, 22);
            label5.TabIndex = 14;
            label5.Text = "Tutar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(23, 187);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 12;
            label4.Text = "Üye Ad Soyad";
            // 
            // Periyot
            // 
            Periyot.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Periyot.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Periyot.Format = DateTimePickerFormat.Short;
            Periyot.Location = new Point(23, 146);
            Periyot.Name = "Periyot";
            Periyot.Size = new Size(200, 29);
            Periyot.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(23, 110);
            label6.Name = "label6";
            label6.Size = new Size(97, 22);
            label6.TabIndex = 16;
            label6.Text = "Ödeme Ayı";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(67, 382);
            button4.Name = "button4";
            button4.Size = new Size(122, 33);
            button4.TabIndex = 42;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(23, 342);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 41;
            button3.Text = "Ödeme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(144, 342);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 40;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(399, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // OdemeTb
            // 
            OdemeTb.CustomizableEdges = customizableEdges3;
            OdemeTb.DefaultText = "";
            OdemeTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OdemeTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OdemeTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OdemeTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OdemeTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OdemeTb.Font = new Font("Segoe UI", 9F);
            OdemeTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OdemeTb.Location = new Point(23, 289);
            OdemeTb.Name = "OdemeTb";
            OdemeTb.PasswordChar = '\0';
            OdemeTb.PlaceholderText = "";
            OdemeTb.SelectedText = "";
            OdemeTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            OdemeTb.Size = new Size(200, 36);
            OdemeTb.TabIndex = 50;
            // 
            // AdSoyadCb
            // 
            AdSoyadCb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdSoyadCb.ForeColor = Color.Red;
            AdSoyadCb.FormattingEnabled = true;
            AdSoyadCb.Items.AddRange(new object[] { "Bay", "Bayan" });
            AdSoyadCb.Location = new Point(23, 225);
            AdSoyadCb.Name = "AdSoyadCb";
            AdSoyadCb.Size = new Size(206, 26);
            AdSoyadCb.TabIndex = 51;
            // 
            // OdemeDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            OdemeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            OdemeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            OdemeDGV.ColumnHeadersHeight = 30;
            OdemeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            OdemeDGV.DefaultCellStyle = dataGridViewCellStyle6;
            OdemeDGV.GridColor = Color.FromArgb(231, 229, 255);
            OdemeDGV.Location = new Point(262, 146);
            OdemeDGV.Name = "OdemeDGV";
            OdemeDGV.RowHeadersVisible = false;
            OdemeDGV.Size = new Size(596, 301);
            OdemeDGV.TabIndex = 52;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OdemeDGV.ThemeStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OdemeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OdemeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OdemeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            OdemeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OdemeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OdemeDGV.ThemeStyle.HeaderStyle.Height = 30;
            OdemeDGV.ThemeStyle.ReadOnly = false;
            OdemeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OdemeDGV.ThemeStyle.RowsStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OdemeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OdemeDGV.ThemeStyle.RowsStyle.Height = 25;
            OdemeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Red;
            OdemeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            OdemeDGV.CellContentClick += OdemeDGV_CellContentClick;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(891, 490);
            Controls.Add(OdemeDGV);
            Controls.Add(AdSoyadCb);
            Controls.Add(OdemeTb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(Periyot);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odeme";
            Load += Odeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox2;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private DateTimePicker Periyot;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox OdemeTb;
        private ComboBox AdSoyadCb;
        private Guna.UI2.WinForms.Guna2DataGridView OdemeDGV;
    }
}