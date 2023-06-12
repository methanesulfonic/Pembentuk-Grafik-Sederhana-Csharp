namespace test
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
            this.btnLuasLingkaran = new System.Windows.Forms.Button();
            this.btn_LuasPersegi = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.jarijariTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panjangTextBox = new System.Windows.Forms.TextBox();
            this.lebarTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuasLingkaran
            // 
            this.btnLuasLingkaran.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuasLingkaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuasLingkaran.FlatAppearance.BorderSize = 0;
            this.btnLuasLingkaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuasLingkaran.Image = global::test.Properties.Resources.tick__Button_Icons_;
            this.btnLuasLingkaran.Location = new System.Drawing.Point(88, 59);
            this.btnLuasLingkaran.Name = "btnLuasLingkaran";
            this.btnLuasLingkaran.Size = new System.Drawing.Size(28, 28);
            this.btnLuasLingkaran.TabIndex = 0;
            this.btnLuasLingkaran.UseVisualStyleBackColor = false;
            this.btnLuasLingkaran.Click += new System.EventHandler(this.btnLuasLingkaran_Click);
            // 
            // btn_LuasPersegi
            // 
            this.btn_LuasPersegi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_LuasPersegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_LuasPersegi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LuasPersegi.FlatAppearance.BorderSize = 0;
            this.btn_LuasPersegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuasPersegi.Image = global::test.Properties.Resources.tick__Button_Icons_;
            this.btn_LuasPersegi.Location = new System.Drawing.Point(88, 93);
            this.btn_LuasPersegi.Name = "btn_LuasPersegi";
            this.btn_LuasPersegi.Size = new System.Drawing.Size(28, 28);
            this.btn_LuasPersegi.TabIndex = 1;
            this.btn_LuasPersegi.UseVisualStyleBackColor = false;
            this.btn_LuasPersegi.Click += new System.EventHandler(this.btn_LuasPersegi_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLabel.Location = new System.Drawing.Point(326, 78);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(72, 36);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Bentuk   :\r\nLuas       :";
            // 
            // jarijariTextBox
            // 
            this.jarijariTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jarijariTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jarijariTextBox.ForeColor = System.Drawing.Color.Black;
            this.jarijariTextBox.Location = new System.Drawing.Point(16, 26);
            this.jarijariTextBox.Name = "jarijariTextBox";
            this.jarijariTextBox.Size = new System.Drawing.Size(100, 24);
            this.jarijariTextBox.TabIndex = 3;
            this.jarijariTextBox.Text = "Jari-jari";
            this.jarijariTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jarijariTextBox.Click += new System.EventHandler(this.shapeTextBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuasLingkaran);
            this.groupBox1.Controls.Add(this.jarijariTextBox);
            this.groupBox1.Location = new System.Drawing.Point(326, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luas Lingkaran";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 288);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafik";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.panel1.Size = new System.Drawing.Size(294, 265);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panjangTextBox
            // 
            this.panjangTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panjangTextBox.ForeColor = System.Drawing.Color.Black;
            this.panjangTextBox.Location = new System.Drawing.Point(16, 27);
            this.panjangTextBox.Name = "panjangTextBox";
            this.panjangTextBox.Size = new System.Drawing.Size(100, 24);
            this.panjangTextBox.TabIndex = 4;
            this.panjangTextBox.Text = "Panjang";
            this.panjangTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panjangTextBox.Click += new System.EventHandler(this.lengthTextBox_Click);
            // 
            // lebarTextBox
            // 
            this.lebarTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lebarTextBox.ForeColor = System.Drawing.Color.Black;
            this.lebarTextBox.Location = new System.Drawing.Point(16, 60);
            this.lebarTextBox.Name = "lebarTextBox";
            this.lebarTextBox.Size = new System.Drawing.Size(100, 24);
            this.lebarTextBox.TabIndex = 5;
            this.lebarTextBox.Text = "Lebar";
            this.lebarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lebarTextBox.Click += new System.EventHandler(this.widthTextBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LuasPersegi);
            this.groupBox2.Controls.Add(this.lebarTextBox);
            this.groupBox2.Controls.Add(this.panjangTextBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(326, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 133);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luas Persegi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pembentuk Grafik Bentuk Sederhana";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::test.Properties.Resources.black18__Button_Icons_;
            this.button2.Location = new System.Drawing.Point(425, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 18);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::test.Properties.Resources.i8__Button_Icons_;
            this.button1.Location = new System.Drawing.Point(451, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 26);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(476, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembentuk Grafik Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLuasLingkaran;
        private Button btn_LuasPersegi;
        private Label resultLabel;
        private TextBox jarijariTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Panel panel1;
        private TextBox panjangTextBox;
        private TextBox lebarTextBox;
        private GroupBox groupBox2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Panel panel2;
    }
}