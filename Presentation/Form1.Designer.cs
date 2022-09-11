namespace Presentation
{
    partial class Form1
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
            this.btnOkulEkle = new System.Windows.Forms.Button();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.txtNumberOfStudent = new System.Windows.Forms.TextBox();
            this.txtNumberOfEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOkulListele = new System.Windows.Forms.Button();
            this.btnOkulGuncelle = new System.Windows.Forms.Button();
            this.btnOkulSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOgretmenListele = new System.Windows.Forms.Button();
            this.btnOgretmenGuncelle = new System.Windows.Forms.Button();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.txtOgrSayısı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.dgwOkul = new System.Windows.Forms.DataGridView();
            this.dgwOgretmen = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOkul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkulEkle
            // 
            this.btnOkulEkle.Location = new System.Drawing.Point(33, 163);
            this.btnOkulEkle.Name = "btnOkulEkle";
            this.btnOkulEkle.Size = new System.Drawing.Size(130, 41);
            this.btnOkulEkle.TabIndex = 0;
            this.btnOkulEkle.Text = "Ekle";
            this.btnOkulEkle.UseVisualStyleBackColor = true;
            this.btnOkulEkle.Click += new System.EventHandler(this.btnOkulEkle_Click);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(117, 19);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(245, 20);
            this.txtSchoolName.TabIndex = 1;
            // 
            // txtNumberOfStudent
            // 
            this.txtNumberOfStudent.Location = new System.Drawing.Point(117, 45);
            this.txtNumberOfStudent.Name = "txtNumberOfStudent";
            this.txtNumberOfStudent.Size = new System.Drawing.Size(245, 20);
            this.txtNumberOfStudent.TabIndex = 2;
            // 
            // txtNumberOfEmployee
            // 
            this.txtNumberOfEmployee.Location = new System.Drawing.Point(117, 71);
            this.txtNumberOfEmployee.Name = "txtNumberOfEmployee";
            this.txtNumberOfEmployee.Size = new System.Drawing.Size(245, 20);
            this.txtNumberOfEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Okul Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çalışan Sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOkulListele);
            this.groupBox1.Controls.Add(this.btnOkulGuncelle);
            this.groupBox1.Controls.Add(this.btnOkulSil);
            this.groupBox1.Controls.Add(this.txtSchoolName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOkulEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberOfStudent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumberOfEmployee);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 229);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okul Ekle";
            // 
            // btnOkulListele
            // 
            this.btnOkulListele.Location = new System.Drawing.Point(441, 163);
            this.btnOkulListele.Name = "btnOkulListele";
            this.btnOkulListele.Size = new System.Drawing.Size(130, 41);
            this.btnOkulListele.TabIndex = 9;
            this.btnOkulListele.Text = "Listele";
            this.btnOkulListele.UseVisualStyleBackColor = true;
            this.btnOkulListele.Click += new System.EventHandler(this.btnOkulListele_Click);
            // 
            // btnOkulGuncelle
            // 
            this.btnOkulGuncelle.Location = new System.Drawing.Point(305, 163);
            this.btnOkulGuncelle.Name = "btnOkulGuncelle";
            this.btnOkulGuncelle.Size = new System.Drawing.Size(130, 41);
            this.btnOkulGuncelle.TabIndex = 8;
            this.btnOkulGuncelle.Text = "Guncelle";
            this.btnOkulGuncelle.UseVisualStyleBackColor = true;
            this.btnOkulGuncelle.Click += new System.EventHandler(this.btnOkulGuncelle_Click);
            // 
            // btnOkulSil
            // 
            this.btnOkulSil.Location = new System.Drawing.Point(169, 163);
            this.btnOkulSil.Name = "btnOkulSil";
            this.btnOkulSil.Size = new System.Drawing.Size(130, 41);
            this.btnOkulSil.TabIndex = 7;
            this.btnOkulSil.Text = "Sil";
            this.btnOkulSil.UseVisualStyleBackColor = true;
            this.btnOkulSil.Click += new System.EventHandler(this.btnOkulSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOgretmenListele);
            this.groupBox2.Controls.Add(this.btnOgretmenGuncelle);
            this.groupBox2.Controls.Add(this.btnOgretmenSil);
            this.groupBox2.Controls.Add(this.btnOgretmenEkle);
            this.groupBox2.Controls.Add(this.txtOgrSayısı);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rdbBekar);
            this.groupBox2.Controls.Add(this.rdbEvli);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaas);
            this.groupBox2.Location = new System.Drawing.Point(627, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 229);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğretmen Ekle";
            // 
            // btnOgretmenListele
            // 
            this.btnOgretmenListele.Location = new System.Drawing.Point(441, 163);
            this.btnOgretmenListele.Name = "btnOgretmenListele";
            this.btnOgretmenListele.Size = new System.Drawing.Size(130, 41);
            this.btnOgretmenListele.TabIndex = 15;
            this.btnOgretmenListele.Text = "Listele";
            this.btnOgretmenListele.UseVisualStyleBackColor = true;
            this.btnOgretmenListele.Click += new System.EventHandler(this.btnOgretmenListele_Click);
            // 
            // btnOgretmenGuncelle
            // 
            this.btnOgretmenGuncelle.Location = new System.Drawing.Point(305, 163);
            this.btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            this.btnOgretmenGuncelle.Size = new System.Drawing.Size(130, 41);
            this.btnOgretmenGuncelle.TabIndex = 14;
            this.btnOgretmenGuncelle.Text = "Guncelle";
            this.btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Location = new System.Drawing.Point(169, 163);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(130, 41);
            this.btnOgretmenSil.TabIndex = 13;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(33, 163);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(130, 41);
            this.btnOgretmenEkle.TabIndex = 12;
            this.btnOgretmenEkle.Text = "Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // txtOgrSayısı
            // 
            this.txtOgrSayısı.Location = new System.Drawing.Point(151, 115);
            this.txtOgrSayısı.Name = "txtOgrSayısı";
            this.txtOgrSayısı.Size = new System.Drawing.Size(162, 20);
            this.txtOgrSayısı.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "OGR SAYISI :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "MEDENİ DURUM :";
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Location = new System.Drawing.Point(205, 97);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(61, 17);
            this.rdbBekar.TabIndex = 8;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "BEKAR";
            this.rdbBekar.UseVisualStyleBackColor = true;
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(151, 97);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(48, 17);
            this.rdbEvli.TabIndex = 7;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "EVLİ";
            this.rdbEvli.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(151, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAAŞ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SOYAD :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(151, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "AD :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(151, 71);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(162, 20);
            this.txtMaas.TabIndex = 3;
            // 
            // dgwOkul
            // 
            this.dgwOkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOkul.Location = new System.Drawing.Point(31, 247);
            this.dgwOkul.Name = "dgwOkul";
            this.dgwOkul.Size = new System.Drawing.Size(590, 490);
            this.dgwOkul.TabIndex = 9;
            this.dgwOkul.SelectionChanged += new System.EventHandler(this.dgwOkul_SelectionChanged);
            // 
            // dgwOgretmen
            // 
            this.dgwOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgretmen.Location = new System.Drawing.Point(627, 247);
            this.dgwOgretmen.Name = "dgwOgretmen";
            this.dgwOgretmen.Size = new System.Drawing.Size(590, 490);
            this.dgwOgretmen.TabIndex = 10;
            this.dgwOgretmen.SelectionChanged += new System.EventHandler(this.dgwOgretmen_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 749);
            this.Controls.Add(this.dgwOgretmen);
            this.Controls.Add(this.dgwOkul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOkul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkulEkle;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.TextBox txtNumberOfStudent;
        private System.Windows.Forms.TextBox txtNumberOfEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.DataGridView dgwOkul;
        private System.Windows.Forms.DataGridView dgwOgretmen;
        private System.Windows.Forms.TextBox txtOgrSayısı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.Button btnOkulListele;
        private System.Windows.Forms.Button btnOkulGuncelle;
        private System.Windows.Forms.Button btnOkulSil;
        private System.Windows.Forms.Button btnOgretmenListele;
        private System.Windows.Forms.Button btnOgretmenGuncelle;
        private System.Windows.Forms.Button btnOgretmenSil;
        private System.Windows.Forms.Button btnOgretmenEkle;
    }
}

