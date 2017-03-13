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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System.Drawing.Printing;

namespace ProjectManagement
{
    public partial class frmYonetici : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int kID;
        string projead;
        Login LoginBack;
        public frmYonetici(string kullaniciAdi)
        {
            YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1();
            kID = DB.Users.Where(k => k.UserNickname == kullaniciAdi).Select(k => k.UsersID).FirstOrDefault();
               

            InitializeComponent();
            ListeDoldur();
        }
        public frmYonetici(string kullaniciAdi, Login l)
        {
            LoginBack = l;
            LoginBack.Hide();
            YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1();
            kID = DB.Users.Where(k => k.UserNickname == kullaniciAdi).Select(k => k.UsersID).FirstOrDefault();
            InitializeComponent();
            ListeDoldur();

        }
        public string Aktiflik(bool A)
        {
            return A == true ? "Aktif" : "Aktif Değil";
        }
        private void ListeDoldur()
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {

                List<Projects> projeler = new List<Projects>();
                projeler = db.Projects.Where(k => k.ProjectUserID == kID).ToList();

                for (int i = 0; i < projeler.Count; i++)
                {
                    lstYntcProjeList.Items.Add(projeler[i].ProjectName);
                    lstYntcProjeList.Items[i].SubItems.Add(projeler[i].Process.Count.ToString());
                    lstYntcProjeList.Items[i].SubItems.Add(projeler[i].Users.UserName + " " + projeler[i].Users.UserSurname);
                    lstYntcProjeList.Items[i].SubItems.Add(projeler[i].StartDate.Value.ToShortDateString());
                    lstYntcProjeList.Items[i].SubItems.Add(projeler[i].FinishDate.Value.ToShortDateString());
                    lstYntcProjeList.Items[i].SubItems.Add(Aktiflik(projeler[i].isActive.Value));
                    lstYntcProjeList.Items[i].SubItems.Add(String.Format("{0:0.##}", projeler[i].Budget) + " TL");
                    lstYntcProjeList.Items[i].SubItems.Add(projeler[i].ProjectID.ToString());
                }
            }
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {

            using (YazilimYonetimAraciEntities1 DB = new YazilimYonetimAraciEntities1())
            {
                string ad = DB.Users.Where(k => k.UsersID == kID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault();
                this.Text = ad + " | Yönetici Paneli";
            }
        }

        private void btnSurecEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lstYntcProjeList.SelectedItems.Count > 0)
            {
                int seciliid = lstYntcProjeList.Items.IndexOf(lstYntcProjeList.SelectedItems[0]);
                projead = lstYntcProjeList.Items[seciliid].Text;

                int seciliPrjID = Convert.ToInt32(lstYntcProjeList.Items.IndexOf(lstYntcProjeList.FocusedItem));
                int projeID = Convert.ToInt32(lstYntcProjeList.Items[seciliPrjID].SubItems[7].Text);

                this.Close();
                frmProssesEkle pr = new frmProssesEkle(kID, projead, projeID);
                pr.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Proje Seçin...!");
            }

        }

        private void btnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            if (LoginBack != null)
            {
                LoginBack.Show();
            }
            else
            {
                Login lgn = new Login();
                lgn.Show();
            }
        }

        private void lstYntcProjeList_DoubleClick(object sender, EventArgs e)
        {
            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();

            int seciliPrjID = Convert.ToInt32(lstYntcProjeList.Items.IndexOf(lstYntcProjeList.FocusedItem));
            int projeID = Convert.ToInt32(lstYntcProjeList.Items[seciliPrjID].SubItems[7].Text);

            if (db.Projects.Where(u => u.ProjectID == projeID).Select(p => p.Process.Count).FirstOrDefault() == 0)
            {
                MessageBox.Show("Seçilen Projenin Süreci Bulunmamaktadır..");
            }
            else
            {
                int seciliid = lstYntcProjeList.Items.IndexOf(lstYntcProjeList.SelectedItems[0]);
                projead = lstYntcProjeList.Items[seciliid].Text;
                this.Close();
                Surecler src = new Surecler(kID, projeID, projead);
                src.Show();
            }
        }

        private void btnYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListViewPrinter printer = new ListViewPrinter(lstYntcProjeList, new Point(15, 25), true, lstYntcProjeList.Groups.Count > 0, "Proje Listesi");
            printer.print();
        }

        private void frmYonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

    }
}