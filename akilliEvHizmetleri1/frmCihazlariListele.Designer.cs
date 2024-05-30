namespace akilliEvHizmetleri1
{
    partial class frmCihazlariListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCihazlariListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCihazTuru = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCihazNo = new System.Windows.Forms.TextBox();
            this.txtEvNo = new System.Windows.Forms.TextBox();
            this.comboCihazDurum = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOlayTuru = new System.Windows.Forms.TextBox();
            this.txtOlayNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEtkilesimTuru = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCihazSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txtCihazTuru
            // 
            this.txtCihazTuru.Location = new System.Drawing.Point(108, 151);
            this.txtCihazTuru.Name = "txtCihazTuru";
            this.txtCihazTuru.Size = new System.Drawing.Size(200, 22);
            this.txtCihazTuru.TabIndex = 37;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekran görüntüsü 2024-05-03 192019.png");
            this.ımageList1.Images.SetKeyName(1, "Ekran görüntüsü 2024-05-03 203619.png");
            this.ımageList1.Images.SetKeyName(2, "Ekran görüntüsü 2024-05-03 203649.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ev No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cihaz Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cihaz Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cihaz No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCihazNo
            // 
            this.txtCihazNo.Location = new System.Drawing.Point(108, 123);
            this.txtCihazNo.Name = "txtCihazNo";
            this.txtCihazNo.Size = new System.Drawing.Size(200, 22);
            this.txtCihazNo.TabIndex = 29;
            this.txtCihazNo.TextChanged += new System.EventHandler(this.txtEposta_TextChanged);
            // 
            // txtEvNo
            // 
            this.txtEvNo.Location = new System.Drawing.Point(108, 95);
            this.txtEvNo.Name = "txtEvNo";
            this.txtEvNo.Size = new System.Drawing.Size(200, 22);
            this.txtEvNo.TabIndex = 28;
            // 
            // comboCihazDurum
            // 
            this.comboCihazDurum.FormattingEnabled = true;
            this.comboCihazDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboCihazDurum.Location = new System.Drawing.Point(108, 179);
            this.comboCihazDurum.Name = "comboCihazDurum";
            this.comboCihazDurum.Size = new System.Drawing.Size(200, 24);
            this.comboCihazDurum.TabIndex = 45;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 2;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(956, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 44);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Olay Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImageIndex = 0;
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(177, 416);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 44);
            this.btnIptal.TabIndex = 35;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(34, 416);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 44);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Olay No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Etkileşim Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Olay Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Olay Türü";
            // 
            // txtOlayTuru
            // 
            this.txtOlayTuru.Location = new System.Drawing.Point(108, 237);
            this.txtOlayTuru.Name = "txtOlayTuru";
            this.txtOlayTuru.Size = new System.Drawing.Size(200, 22);
            this.txtOlayTuru.TabIndex = 47;
            this.txtOlayTuru.TextChanged += new System.EventHandler(this.txtOlayTuru_TextChanged);
            // 
            // txtOlayNo
            // 
            this.txtOlayNo.Location = new System.Drawing.Point(108, 209);
            this.txtOlayNo.Name = "txtOlayNo";
            this.txtOlayNo.Size = new System.Drawing.Size(200, 22);
            this.txtOlayNo.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // txtEtkilesimTuru
            // 
            this.txtEtkilesimTuru.Location = new System.Drawing.Point(108, 293);
            this.txtEtkilesimTuru.Name = "txtEtkilesimTuru";
            this.txtEtkilesimTuru.Size = new System.Drawing.Size(200, 22);
            this.txtEtkilesimTuru.TabIndex = 47;
            this.txtEtkilesimTuru.TextChanged += new System.EventHandler(this.txtOlayTuru_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(328, 332);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(622, 185);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Güvenlik Cihazları Listesi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Olay Olan Guvenlik Cihazları";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnCihazSil
            // 
            this.btnCihazSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCihazSil.ImageIndex = 2;
            this.btnCihazSil.ImageList = this.ımageList1;
            this.btnCihazSil.Location = new System.Drawing.Point(956, 332);
            this.btnCihazSil.Name = "btnCihazSil";
            this.btnCihazSil.Size = new System.Drawing.Size(108, 44);
            this.btnCihazSil.TabIndex = 58;
            this.btnCihazSil.Text = "Cihaz Sil";
            this.btnCihazSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCihazSil.UseVisualStyleBackColor = true;
            this.btnCihazSil.Click += new System.EventHandler(this.btnCihazSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(850, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(783, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "Cihaz No";
            // 
            // frmCihazlariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 607);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCihazSil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEtkilesimTuru);
            this.Controls.Add(this.txtOlayTuru);
            this.Controls.Add(this.txtOlayNo);
            this.Controls.Add(this.comboCihazDurum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtCihazTuru);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCihazNo);
            this.Controls.Add(this.txtEvNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCihazlariListele";
            this.Text = "Cihaz Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmCihazListele_Load);
            this.DoubleClick += new System.EventHandler(this.frmAraçListele_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCihazTuru;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCihazNo;
        private System.Windows.Forms.TextBox txtEvNo;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboCihazDurum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOlayTuru;
        private System.Windows.Forms.TextBox txtOlayNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEtkilesimTuru;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCihazSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}