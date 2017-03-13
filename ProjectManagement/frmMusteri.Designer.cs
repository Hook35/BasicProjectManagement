namespace ProjectManagement
{
    partial class frmMusteri
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDegistir = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.Baslik = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.areLogin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 672);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1342, 40);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEkle,
            this.btnDegistir,
            this.btnYazdir,
            this.barButtonItem1,
            this.btnCikis,
            this.btnSil});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Baslik});
            this.ribbon.Size = new System.Drawing.Size(1342, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "Ekle";
            this.btnEkle.Id = 1;
            this.btnEkle.ImageUri.Uri = "Add";
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEkle_ItemClick);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Caption = "Değiştir";
            this.btnDegistir.Id = 2;
            this.btnDegistir.ImageUri.Uri = "Edit";
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDegistir_ItemClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Id = 10;
            this.btnYazdir.Name = "btnYazdir";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "ÇIKIŞ";
            this.btnCikis.Id = 8;
            this.btnCikis.ImageUri.Uri = "Close";
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikis_ItemClick);
            // 
            // Baslik
            // 
            this.Baslik.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.areLogin});
            this.Baslik.Name = "Baslik";
            this.Baslik.Text = "Ana Sayfa";
            // 
            // areLogin
            // 
            this.areLogin.ItemLinks.Add(this.btnEkle);
            this.areLogin.ItemLinks.Add(this.btnDegistir);
            this.areLogin.ItemLinks.Add(this.btnCikis);
            this.areLogin.ItemLinks.Add(this.btnSil);
            this.areLogin.Name = "areLogin";
            this.areLogin.Text = "Giriş";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataSource = typeof(ProjectManagement.Projects);
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Caption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeList1.Appearance.Caption.Options.UseFont = true;
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.treeList1.Location = new System.Drawing.Point(12, 185);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(1318, 481);
            this.treeList1.TabIndex = 14;
            this.treeList1.ShownEditor += new System.EventHandler(this.treeList1_ShownEditor);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "SİL";
            this.btnSil.Id = 11;
            this.btnSil.ImageUri.Uri = "Clear";
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 712);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "frmMusteri";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Proje";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnDegistir;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage Baslik;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup areLogin;
        private DevExpress.XtraBars.BarButtonItem btnSil;
    }
}