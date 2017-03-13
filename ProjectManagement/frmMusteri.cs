using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.Nodes;
using System.Data.Entity;
using DevExpress.XtraTreeList;

namespace ProjectManagement
{
    public partial class frmMusteri : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int kID;
        Login LoginBack;
        string kAd;
        public frmMusteri(string kullaniciAdi)
        {
            YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1();
            kID = DB.Users.Where(k => k.UserNickname == kullaniciAdi).Select(k => k.UsersID).FirstOrDefault();
            this.kAd = kullaniciAdi;
            InitializeComponent();
            CreateColumns(treeList1);
            CreateNodes(treeList1);

        }
        public frmMusteri(string kullaniciAdi, Login l)
        {
            LoginBack = l;
            LoginBack.Hide();
            this.kAd = kullaniciAdi;
            YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1();
            kID = DB.Users.Where(k => k.UserNickname == kullaniciAdi).Select(k => k.UsersID).FirstOrDefault();

            InitializeComponent();
            CreateColumns(treeList1);
            CreateNodes(treeList1);
        }

        private void CreateColumns(TreeList tl)
        {
            // Create three columns.
            tl.BeginUpdate();
            tl.Columns.Add();
            tl.Columns[0].Caption = "Proje Adı";
            tl.Columns[0].VisibleIndex = 0;
            tl.Columns.Add();
            tl.Columns[1].Caption = "Süreçler";
            tl.Columns[1].VisibleIndex = 1;
            tl.Columns.Add();
            tl.Columns[2].Caption = "Proje Yöneticisi";
            tl.Columns[2].VisibleIndex = 2;
            tl.Columns.Add();
            tl.Columns[3].Caption = "Başlangıç Tarihi";
            tl.Columns[3].VisibleIndex = 3;
            tl.Columns.Add();
            tl.Columns[4].Caption = "Bitiş Tarihi";
            tl.Columns[4].VisibleIndex = 4;
            tl.Columns.Add();
            tl.Columns[5].Caption = "Aktiflik";
            tl.Columns[5].VisibleIndex = 5;
            tl.Columns.Add();
            tl.Columns[6].Caption = "Bütçe";
            tl.Columns[6].VisibleIndex = 6;
            tl.Columns.Add();
            tl.Columns[7].Caption = "Proje ID";
            tl.Columns[7].VisibleIndex = 7;

            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl)
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                List<Projects> projeler = new List<Projects>();
                projeler = db.Projects.Where(k => k.CreateUserID == kID).ToList();

                foreach (var item in projeler)
                {
                    tl.BeginUnboundLoad();
                    //  string surec=item.Process.Where(p=>p.ProjectID==item.ProjectID).Select(p=>p.ProcessName);
                    // Create a root node .
                    TreeListNode parentForRootNodes = null;
                    TreeListNode rootNode = tl.AppendNode(
                        new object[] { item.ProjectName, item.Process.Count, item.Users1.UserName + " " + item.Users1.UserSurname, item.StartDate.Value.ToShortDateString(), item.FinishDate.Value.ToShortDateString(), Aktiflik(item.isActive.Value), item.Budget + " TL", item.ProjectID },
                        parentForRootNodes);

                    string[] prosses_header = { "Süreç Adı", "Tamamlanma Oranı" };
                    tl.AppendNode(prosses_header, rootNode);
                    for (int i = 0; i < item.Process.Count; i++)
                    {
                        tl.AppendNode(new object[] { i + 1 + "-) " + item.Process.ToList()[i].ProcessName, "Tamamlanma: %" + item.Process.ToList()[i].CompleteRate }, rootNode);
                    }



                    tl.EndUnboundLoad();
                }

            }

        }
        private void btnEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            frmMusteriPrjEkle mp_ekle = new frmMusteriPrjEkle(kID);
            mp_ekle.Show();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            using (YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1())
            {
                string ad = DB.Users.Where(k => k.UsersID == kID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault();
                this.Text = ad + " | Projeler Listesi";

            }


        }

        private void btnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            LoginBack = new Login();
            LoginBack.Show();
        }

        private void treeList1_ShownEditor(object sender, EventArgs e)
        {
            ((TreeList)sender).ActiveEditor.Properties.ReadOnly = true;
        }
        public string Aktiflik(bool A)
        {
            return A == true ? "Aktif" : "Aktif Değil";
        }

        private void btnDegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (treeList1.FocusedNode != null)
            {
                using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
                {

                    DevExpress.XtraTreeList.Nodes.TreeListNode node = treeList1.FocusedNode;
                    int PID = Convert.ToInt32(node.GetDisplayText(treeList1.VisibleColumns[7]));

                    this.Close();
                    frmMusteriPrjEkle pupdate = new frmMusteriPrjEkle(kID, true, PID);
                    pupdate.ShowDialog();


                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Proje Seçiniz..");
            }

        }
        
        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (treeList1.FocusedNode != null)
            {
                using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode node = treeList1.FocusedNode;
                    int PID = Convert.ToInt32(node.GetDisplayText(treeList1.VisibleColumns[7]));
                    if (MessageBox.Show(node.GetDisplayText(treeList1.VisibleColumns[0]) + "\nprojesini silmek istiyor musunuz?", "Proje Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                            /*Projects category = db.Projects.Where(c => c.ProjectID == PID).FirstOrDefault();
                            db.Projects.DeleteOnSubmit(category);
                            db.SubmitChanges();*/

                            Projects p = db.Projects.Single(c => c.ProjectID == PID);
                            db.Projects.Remove(p);

                            db.SaveChanges();

                            this.Close();
                            frmMusteri m = new frmMusteri(this.kAd);
                            m.Show();
                        
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Proje Seçiniz..");
            }
        }
    }
}