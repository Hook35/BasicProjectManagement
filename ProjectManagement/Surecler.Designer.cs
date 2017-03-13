namespace ProjectManagement
{
    partial class Surecler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surecler));
            this.lstProsses = new System.Windows.Forms.ListView();
            this.prcsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.strtDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fnshDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prssID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.lblProjeAd = new DevExpress.XtraEditors.LabelControl();
            this.btnAltSurecEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnIsTakibi = new DevExpress.XtraEditors.SimpleButton();
            this.btnAltSurecDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chxAktiflik = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstProsses
            // 
            this.lstProsses.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstProsses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prcsName,
            this.strtDate,
            this.fnshDate,
            this.durtn,
            this.comRate,
            this.priority,
            this.note,
            this.desc,
            this.prssID});
            this.lstProsses.FullRowSelect = true;
            this.lstProsses.GridLines = true;
            this.lstProsses.Location = new System.Drawing.Point(12, 54);
            this.lstProsses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProsses.MultiSelect = false;
            this.lstProsses.Name = "lstProsses";
            this.lstProsses.Size = new System.Drawing.Size(1027, 360);
            this.lstProsses.TabIndex = 0;
            this.lstProsses.UseCompatibleStateImageBehavior = false;
            this.lstProsses.View = System.Windows.Forms.View.Details;
            // 
            // prcsName
            // 
            this.prcsName.Text = "Süreç İsmi";
            this.prcsName.Width = 128;
            // 
            // strtDate
            // 
            this.strtDate.Text = "Başlangıç Tarihi";
            this.strtDate.Width = 108;
            // 
            // fnshDate
            // 
            this.fnshDate.Text = "Bitiş Tarihi";
            this.fnshDate.Width = 92;
            // 
            // durtn
            // 
            this.durtn.Text = "Süre";
            // 
            // comRate
            // 
            this.comRate.Text = "Tamamlanma Oranı";
            this.comRate.Width = 129;
            // 
            // priority
            // 
            this.priority.Text = "Öncelik";
            this.priority.Width = 83;
            // 
            // note
            // 
            this.note.Text = "Not";
            this.note.Width = 46;
            // 
            // desc
            // 
            this.desc.Text = "Açıklama";
            this.desc.Width = 92;
            // 
            // prssID
            // 
            this.prssID.Text = "Süreç ID";
            this.prssID.Width = 144;
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(840, 7);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(199, 41);
            this.btnGeri.TabIndex = 71;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblProjeAd
            // 
            this.lblProjeAd.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAd.Location = new System.Drawing.Point(12, 12);
            this.lblProjeAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProjeAd.Name = "lblProjeAd";
            this.lblProjeAd.Size = new System.Drawing.Size(0, 36);
            this.lblProjeAd.TabIndex = 73;
            // 
            // btnAltSurecEkle
            // 
            this.btnAltSurecEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltSurecEkle.Appearance.Options.UseFont = true;
            this.btnAltSurecEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAltSurecEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnAltSurecEkle.Image")));
            this.btnAltSurecEkle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAltSurecEkle.Location = new System.Drawing.Point(711, 418);
            this.btnAltSurecEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltSurecEkle.Name = "btnAltSurecEkle";
            this.btnAltSurecEkle.Size = new System.Drawing.Size(328, 76);
            this.btnAltSurecEkle.TabIndex = 74;
            this.btnAltSurecEkle.Text = "ALT SÜREÇ EKLE";
            this.btnAltSurecEkle.Click += new System.EventHandler(this.btnAltSurecEkle_Click);
            // 
            // btnIsTakibi
            // 
            this.btnIsTakibi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsTakibi.Appearance.Options.UseFont = true;
            this.btnIsTakibi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIsTakibi.Image = ((System.Drawing.Image)(resources.GetObject("btnIsTakibi.Image")));
            this.btnIsTakibi.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnIsTakibi.Location = new System.Drawing.Point(235, 418);
            this.btnIsTakibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsTakibi.Name = "btnIsTakibi";
            this.btnIsTakibi.Size = new System.Drawing.Size(244, 76);
            this.btnIsTakibi.TabIndex = 75;
            this.btnIsTakibi.Text = "İŞ TAKİBİ";
            this.btnIsTakibi.Click += new System.EventHandler(this.btnIsTakibi_Click);
            // 
            // btnAltSurecDuzenle
            // 
            this.btnAltSurecDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltSurecDuzenle.Appearance.Options.UseFont = true;
            this.btnAltSurecDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAltSurecDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnAltSurecDuzenle.Image")));
            this.btnAltSurecDuzenle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAltSurecDuzenle.Location = new System.Drawing.Point(485, 418);
            this.btnAltSurecDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltSurecDuzenle.Name = "btnAltSurecDuzenle";
            this.btnAltSurecDuzenle.Size = new System.Drawing.Size(220, 76);
            this.btnAltSurecDuzenle.TabIndex = 76;
            this.btnAltSurecDuzenle.Text = "SÜREÇ DÜZENLE";
            this.btnAltSurecDuzenle.Click += new System.EventHandler(this.btnAltSurecDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "Proje Aktifliği :";
            // 
            // chxAktiflik
            // 
            this.chxAktiflik.AutoSize = true;
            this.chxAktiflik.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxAktiflik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chxAktiflik.Location = new System.Drawing.Point(156, 464);
            this.chxAktiflik.Name = "chxAktiflik";
            this.chxAktiflik.Size = new System.Drawing.Size(73, 25);
            this.chxAktiflik.TabIndex = 78;
            this.chxAktiflik.Text = "Aktif";
            this.chxAktiflik.UseVisualStyleBackColor = true;
            this.chxAktiflik.CheckedChanged += new System.EventHandler(this.chxAktiflik_CheckedChanged);
            // 
            // Surecler
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 503);
            this.Controls.Add(this.chxAktiflik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltSurecDuzenle);
            this.Controls.Add(this.btnIsTakibi);
            this.Controls.Add(this.btnAltSurecEkle);
            this.Controls.Add(this.lblProjeAd);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lstProsses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Surecler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surecler";
            this.Load += new System.EventHandler(this.Surecler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProsses;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private System.Windows.Forms.ColumnHeader prcsName;
        private System.Windows.Forms.ColumnHeader strtDate;
        private System.Windows.Forms.ColumnHeader fnshDate;
        private System.Windows.Forms.ColumnHeader durtn;
        private System.Windows.Forms.ColumnHeader comRate;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader prssID;
        private DevExpress.XtraEditors.LabelControl lblProjeAd;
        private DevExpress.XtraEditors.SimpleButton btnAltSurecEkle;
        private DevExpress.XtraEditors.SimpleButton btnIsTakibi;
        private DevExpress.XtraEditors.SimpleButton btnAltSurecDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chxAktiflik;
    }
}