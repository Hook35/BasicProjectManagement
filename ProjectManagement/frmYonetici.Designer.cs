namespace ProjectManagement
{
    partial class frmYonetici
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSurecEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lstYntcProjeList = new System.Windows.Forms.ListView();
            this.prjAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjSurecler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjMusteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjBasTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjBitTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjAktv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjButce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSurecEkle,
            this.btnYazdir,
            this.btnCikis});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1204, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSurecEkle
            // 
            this.btnSurecEkle.Caption = "SEÇİLİ PROJEYE SÜREÇ EKLE";
            this.btnSurecEkle.Id = 1;
            this.btnSurecEkle.ImageUri.Uri = "ListMultilevel";
            this.btnSurecEkle.Name = "btnSurecEkle";
            this.btnSurecEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSurecEkle_ItemClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "YAZDIR";
            this.btnYazdir.Id = 2;
            this.btnYazdir.ImageUri.Uri = "Print";
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "ÇIKIŞ";
            this.btnCikis.Id = 3;
            this.btnCikis.ImageUri.Uri = "Close";
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikis_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Anasayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSurecEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYazdir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "GİRİŞ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 654);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1204, 40);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(12, 181);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Atanan Proje Listesi";
            // 
            // lstYntcProjeList
            // 
            this.lstYntcProjeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prjAd,
            this.prjSurecler,
            this.prjMusteri,
            this.prjBasTar,
            this.prjBitTar,
            this.prjAktv,
            this.prjButce,
            this.prjID});
            this.lstYntcProjeList.FullRowSelect = true;
            this.lstYntcProjeList.GridLines = true;
            this.lstYntcProjeList.Location = new System.Drawing.Point(12, 203);
            this.lstYntcProjeList.MultiSelect = false;
            this.lstYntcProjeList.Name = "lstYntcProjeList";
            this.lstYntcProjeList.Size = new System.Drawing.Size(1180, 445);
            this.lstYntcProjeList.TabIndex = 9;
            this.lstYntcProjeList.UseCompatibleStateImageBehavior = false;
            this.lstYntcProjeList.View = System.Windows.Forms.View.Details;
            this.lstYntcProjeList.DoubleClick += new System.EventHandler(this.lstYntcProjeList_DoubleClick);
            // 
            // prjAd
            // 
            this.prjAd.Text = "Proje Adı";
            this.prjAd.Width = 230;
            // 
            // prjSurecler
            // 
            this.prjSurecler.Text = "Süreçler";
            this.prjSurecler.Width = 67;
            // 
            // prjMusteri
            // 
            this.prjMusteri.Text = "Müşteri";
            this.prjMusteri.Width = 106;
            // 
            // prjBasTar
            // 
            this.prjBasTar.Text = "Başlangıç Tarihi";
            this.prjBasTar.Width = 111;
            // 
            // prjBitTar
            // 
            this.prjBitTar.Text = "Bitiş Tarihi";
            this.prjBitTar.Width = 85;
            // 
            // prjAktv
            // 
            this.prjAktv.Text = "Aktiflik";
            this.prjAktv.Width = 76;
            // 
            // prjButce
            // 
            this.prjButce.Text = "Bütçe";
            this.prjButce.Width = 76;
            // 
            // prjID
            // 
            this.prjID.Text = "Proje ID";
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 694);
            this.Controls.Add(this.lstYntcProjeList);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmYonetici";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmYonetici_FormClosing);
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSurecEkle;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListView lstYntcProjeList;
        private System.Windows.Forms.ColumnHeader prjAd;
        private System.Windows.Forms.ColumnHeader prjSurecler;
        private System.Windows.Forms.ColumnHeader prjMusteri;
        private System.Windows.Forms.ColumnHeader prjBasTar;
        private System.Windows.Forms.ColumnHeader prjBitTar;
        private System.Windows.Forms.ColumnHeader prjAktv;
        private System.Windows.Forms.ColumnHeader prjButce;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private System.Windows.Forms.ColumnHeader prjID;
    }
}