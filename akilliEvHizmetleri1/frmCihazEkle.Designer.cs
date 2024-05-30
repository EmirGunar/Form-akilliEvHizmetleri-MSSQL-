namespace akilliEvHizmetleri1
{
    partial class frmCihazEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCihazEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCihazNo = new System.Windows.Forms.TextBox();
            this.txtCihazTur = new System.Windows.Forms.TextBox();
            this.txtEvNo = new System.Windows.Forms.TextBox();
            this.comboCihazDurum = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaz No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cihaz Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cihaz Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ev No";
            // 
            // txtCihazNo
            // 
            this.txtCihazNo.Location = new System.Drawing.Point(194, 75);
            this.txtCihazNo.Name = "txtCihazNo";
            this.txtCihazNo.Size = new System.Drawing.Size(141, 22);
            this.txtCihazNo.TabIndex = 1;
            // 
            // txtCihazTur
            // 
            this.txtCihazTur.Location = new System.Drawing.Point(194, 100);
            this.txtCihazTur.Name = "txtCihazTur";
            this.txtCihazTur.Size = new System.Drawing.Size(141, 22);
            this.txtCihazTur.TabIndex = 1;
            // 
            // txtEvNo
            // 
            this.txtEvNo.Location = new System.Drawing.Point(194, 152);
            this.txtEvNo.Name = "txtEvNo";
            this.txtEvNo.Size = new System.Drawing.Size(141, 22);
            this.txtEvNo.TabIndex = 1;
            // 
            // comboCihazDurum
            // 
            this.comboCihazDurum.FormattingEnabled = true;
            this.comboCihazDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboCihazDurum.Location = new System.Drawing.Point(194, 124);
            this.comboCihazDurum.Name = "comboCihazDurum";
            this.comboCihazDurum.Size = new System.Drawing.Size(141, 24);
            this.comboCihazDurum.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(83, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cihaz Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekran görüntüsü 2024-05-03 192019 - Kopya.png");
            this.ımageList1.Images.SetKeyName(1, "Ekran görüntüsü 2024-05-05 152025.png");
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(229, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCihazEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboCihazDurum);
            this.Controls.Add(this.txtEvNo);
            this.Controls.Add(this.txtCihazTur);
            this.Controls.Add(this.txtCihazNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCihazEkle";
            this.Text = "Cihaz Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmCihazEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCihazNo;
        private System.Windows.Forms.TextBox txtCihazTur;
        private System.Windows.Forms.TextBox txtEvNo;
        private System.Windows.Forms.ComboBox comboCihazDurum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}