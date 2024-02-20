namespace KonteynerKontrollerii
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCpuI7 = new System.Windows.Forms.RadioButton();
            this.rbCpuI5 = new System.Windows.Forms.RadioButton();
            this.rbCpuI3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpuR3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDvd = new System.Windows.Forms.CheckBox();
            this.cbWebCam = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCpuI7
            // 
            this.rbCpuI7.AutoSize = true;
            this.rbCpuI7.Location = new System.Drawing.Point(6, 23);
            this.rbCpuI7.Name = "rbCpuI7";
            this.rbCpuI7.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI7.TabIndex = 0;
            this.rbCpuI7.TabStop = true;
            this.rbCpuI7.Text = "Intel Core i7";
            this.rbCpuI7.UseVisualStyleBackColor = true;
            // 
            // rbCpuI5
            // 
            this.rbCpuI5.AutoSize = true;
            this.rbCpuI5.Location = new System.Drawing.Point(6, 46);
            this.rbCpuI5.Name = "rbCpuI5";
            this.rbCpuI5.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI5.TabIndex = 1;
            this.rbCpuI5.TabStop = true;
            this.rbCpuI5.Text = "Intel Core i5";
            this.rbCpuI5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI3
            // 
            this.rbCpuI3.AutoSize = true;
            this.rbCpuI3.Location = new System.Drawing.Point(6, 69);
            this.rbCpuI3.Name = "rbCpuI3";
            this.rbCpuI3.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI3.TabIndex = 2;
            this.rbCpuI3.TabStop = true;
            this.rbCpuI3.Text = "Intel Core i3";
            this.rbCpuI3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(6, 92);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR5.TabIndex = 3;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "AMD Ryzen 5";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuR3
            // 
            this.rbCpuR3.AutoSize = true;
            this.rbCpuR3.Location = new System.Drawing.Point(6, 115);
            this.rbCpuR3.Name = "rbCpuR3";
            this.rbCpuR3.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR3.TabIndex = 4;
            this.rbCpuR3.TabStop = true;
            this.rbCpuR3.Text = "AMD Ryzen 3";
            this.rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpuI5);
            this.groupBox1.Controls.Add(this.rbCpuR3);
            this.groupBox1.Controls.Add(this.rbCpuI7);
            this.groupBox1.Controls.Add(this.rbCpuR5);
            this.groupBox1.Controls.Add(this.rbCpuI3);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemciler";
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(0, 23);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(55, 17);
            this.rbRam16.TabIndex = 5;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16 GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(0, 69);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(49, 17);
            this.rbRam8.TabIndex = 6;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8 GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(0, 115);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(49, 17);
            this.rbRam4.TabIndex = 7;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4 GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRam8);
            this.groupBox2.Controls.Add(this.rbRam16);
            this.groupBox2.Controls.Add(this.rbRam4);
            this.groupBox2.Location = new System.Drawing.Point(210, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ram Bellek";
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Location = new System.Drawing.Point(6, 14);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(48, 17);
            this.rbHdd1000.TabIndex = 9;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "1 TB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Location = new System.Drawing.Point(6, 60);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(61, 17);
            this.rbHdd500.TabIndex = 10;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500 GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Location = new System.Drawing.Point(6, 106);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(61, 17);
            this.rbHdd320.TabIndex = 11;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320 GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbHdd500);
            this.groupBox3.Controls.Add(this.rbHdd320);
            this.groupBox3.Controls.Add(this.rbHdd1000);
            this.groupBox3.Location = new System.Drawing.Point(430, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 143);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sabit Disk";
            // 
            // cbDvd
            // 
            this.cbDvd.AutoSize = true;
            this.cbDvd.Location = new System.Drawing.Point(6, 26);
            this.cbDvd.Name = "cbDvd";
            this.cbDvd.Size = new System.Drawing.Size(71, 17);
            this.cbDvd.TabIndex = 13;
            this.cbDvd.Text = "DVD RW";
            this.cbDvd.UseVisualStyleBackColor = true;
            // 
            // cbWebCam
            // 
            this.cbWebCam.AutoSize = true;
            this.cbWebCam.Location = new System.Drawing.Point(6, 62);
            this.cbWebCam.Name = "cbWebCam";
            this.cbWebCam.Size = new System.Drawing.Size(73, 17);
            this.cbWebCam.TabIndex = 14;
            this.cbWebCam.Text = "Web Cam";
            this.cbWebCam.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(6, 104);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(88, 17);
            this.cbWifi.TabIndex = 15;
            this.cbWifi.Text = "Wireless Kart";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(274, 201);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(260, 95);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbWebCam);
            this.groupBox4.Controls.Add(this.cbDvd);
            this.groupBox4.Controls.Add(this.cbWifi);
            this.groupBox4.Location = new System.Drawing.Point(24, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 148);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ek Donanımlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCpuI7;
        private System.Windows.Forms.RadioButton rbCpuI5;
        private System.Windows.Forms.RadioButton rbCpuI3;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpuR3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbDvd;
        private System.Windows.Forms.CheckBox cbWebCam;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

