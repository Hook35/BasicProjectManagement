namespace ProjectManagement
{
    partial class frmProssesEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProssesEkle));
            this.lblEndDate = new DevExpress.XtraEditors.LabelControl();
            this.lblBasDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtSrcAd = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nmbOran = new System.Windows.Forms.NumericUpDown();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNot = new DevExpress.XtraEditors.MemoEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblProjeAd = new DevExpress.XtraEditors.LabelControl();
            this.cmbOncelik = new System.Windows.Forms.ComboBox();
            this.btnSurecEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.dateBitis1 = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndDate
            // 
            this.lblEndDate.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndDate.Location = new System.Drawing.Point(567, 95);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(20, 31);
            this.lblEndDate.TabIndex = 59;
            this.lblEndDate.Text = " - ";
            // 
            // lblBasDate
            // 
            this.lblBasDate.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBasDate.Location = new System.Drawing.Point(253, 95);
            this.lblBasDate.Name = "lblBasDate";
            this.lblBasDate.Size = new System.Drawing.Size(20, 31);
            this.lblBasDate.TabIndex = 58;
            this.lblBasDate.Text = " - ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Location = new System.Drawing.Point(452, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(109, 27);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Bitiş Tarihi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(88, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 27);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Başlangıç Tarihi :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(133, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 27);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Süre (Gün) :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(143, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 27);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Süreç Adı :";
            // 
            // txtSure
            // 
            this.txtSure.Enabled = false;
            this.txtSure.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.Location = new System.Drawing.Point(248, 175);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(241, 29);
            this.txtSure.TabIndex = 49;
            // 
            // txtSrcAd
            // 
            this.txtSrcAd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSrcAd.Location = new System.Drawing.Point(248, 62);
            this.txtSrcAd.Name = "txtSrcAd";
            this.txtSrcAd.Size = new System.Drawing.Size(579, 29);
            this.txtSrcAd.TabIndex = 48;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Location = new System.Drawing.Point(5, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(237, 27);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "Tamamlanma Oranı ( % ) :";
            // 
            // nmbOran
            // 
            this.nmbOran.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmbOran.Location = new System.Drawing.Point(248, 213);
            this.nmbOran.Name = "nmbOran";
            this.nmbOran.Size = new System.Drawing.Size(120, 32);
            this.nmbOran.TabIndex = 62;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Location = new System.Drawing.Point(503, 177);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 27);
            this.labelControl7.TabIndex = 64;
            this.labelControl7.Text = "Öncelik :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Location = new System.Drawing.Point(197, 262);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 27);
            this.labelControl8.TabIndex = 66;
            this.labelControl8.Text = "Not :";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(197, 295);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(317, 119);
            this.txtNot.TabIndex = 67;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(520, 295);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(302, 119);
            this.txtAciklama.TabIndex = 69;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Location = new System.Drawing.Point(520, 262);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(96, 27);
            this.labelControl9.TabIndex = 68;
            this.labelControl9.Text = "Açıklama :";
            // 
            // lblProjeAd
            // 
            this.lblProjeAd.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAd.Location = new System.Drawing.Point(102, 20);
            this.lblProjeAd.Name = "lblProjeAd";
            this.lblProjeAd.Size = new System.Drawing.Size(0, 36);
            this.lblProjeAd.TabIndex = 72;
            // 
            // cmbOncelik
            // 
            this.cmbOncelik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOncelik.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOncelik.FormattingEnabled = true;
            this.cmbOncelik.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbOncelik.Location = new System.Drawing.Point(589, 176);
            this.cmbOncelik.Name = "cmbOncelik";
            this.cmbOncelik.Size = new System.Drawing.Size(233, 30);
            this.cmbOncelik.TabIndex = 73;
            // 
            // btnSurecEkle
            // 
            this.btnSurecEkle.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSurecEkle.Appearance.Options.UseFont = true;
            this.btnSurecEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnSurecEkle.Image")));
            this.btnSurecEkle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSurecEkle.Location = new System.Drawing.Point(197, 422);
            this.btnSurecEkle.Name = "btnSurecEkle";
            this.btnSurecEkle.Size = new System.Drawing.Size(625, 68);
            this.btnSurecEkle.TabIndex = 71;
            this.btnSurecEkle.Text = "SÜREÇ EKLE";
            this.btnSurecEkle.Click += new System.EventHandler(this.btnSurecEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(676, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(151, 42);
            this.btnGeri.TabIndex = 70;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dateBitis1
            // 
            this.dateBitis1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis1.Location = new System.Drawing.Point(561, 130);
            this.dateBitis1.Name = "dateBitis1";
            this.dateBitis1.Size = new System.Drawing.Size(263, 29);
            this.dateBitis1.TabIndex = 75;
            this.dateBitis1.ValueChanged += new System.EventHandler(this.dateBitis1_ValueChanged);
            // 
            // dateBaslangic1
            // 
            this.dateBaslangic1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic1.Location = new System.Drawing.Point(248, 130);
            this.dateBaslangic1.Name = "dateBaslangic1";
            this.dateBaslangic1.Size = new System.Drawing.Size(266, 29);
            this.dateBaslangic1.TabIndex = 74;
            this.dateBaslangic1.ValueChanged += new System.EventHandler(this.dateBaslangic1_ValueChanged);
            // 
            // frmProssesEkle
            // 
            this.AcceptButton = this.btnSurecEkle;
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 518);
            this.Controls.Add(this.dateBitis1);
            this.Controls.Add(this.dateBaslangic1);
            this.Controls.Add(this.cmbOncelik);
            this.Controls.Add(this.lblProjeAd);
            this.Controls.Add(this.btnSurecEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.nmbOran);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblBasDate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtSrcAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProssesEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProssesEkle";
            this.Load += new System.EventHandler(this.frmProssesEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbOran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblEndDate;
        private DevExpress.XtraEditors.LabelControl lblBasDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtSrcAd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nmbOran;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtNot;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnSurecEkle;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.LabelControl lblProjeAd;
        private System.Windows.Forms.ComboBox cmbOncelik;
        private System.Windows.Forms.DateTimePicker dateBitis1;
        private System.Windows.Forms.DateTimePicker dateBaslangic1;
    }
}