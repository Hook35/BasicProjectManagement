using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectManagement
{
    public partial class frmMusteriPrjEkle : DevExpress.XtraEditors.XtraForm
    {
        int kID;
        bool Pupdate = false;
        int IDupdate;
        public frmMusteriPrjEkle(int kID)
        {
            InitializeComponent();
            this.kID = kID;
        }
        public frmMusteriPrjEkle(int kID, bool upt, int prjID)
        {
            InitializeComponent();
            this.kID = kID;
            this.Pupdate = upt;
            this.IDupdate = prjID;
            dateBaslangic1.CalendarTitleBackColor = Color.Yellow;
            dateBitis1.CalendarTitleBackColor = Color.Yellow;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();
            string kad = db.Users.Where(k => k.UsersID == kID).Select(u => u.UserNickname).FirstOrDefault();
            frmMusteri MUS = new frmMusteri(kad);
            MUS.Show();
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            if (Pupdate)
            {
                using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
                {
                    var currentuser = db.Users.Where(k => k.UsersID == kID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault();
                    if (TxtKontrol())
                    {
                        Projects prj = db.Projects.Where(p => p.ProjectID == IDupdate).FirstOrDefault();
                        if (prj.Users1.UserName+" "+prj.Users1.UserSurname==cmbProjeLider.Text)
                        {
                            var currentprs = prj.Process;
                            prj.Process = currentprs;
                        }
                        prj.ProjectName = txtPrjAd.Text;
                        prj.Budget = Convert.ToDecimal(txtButce.Text);
                        prj.isActive = false;
                        prj.CreateUserID = kID;
                        prj.ProjectUserID = db.Users.Where(k => k.UserName + " " + k.UserSurname == cmbProjeLider.Text).Select(k => k.UsersID).FirstOrDefault();
                        prj.StartDate = Convert.ToDateTime(lblBasDate.Text);
                        prj.FinishDate = Convert.ToDateTime(lblEndDate.Text);

                        db.SaveChanges();
                        MessageBox.Show("Projeniz Başarıyla Güncellendi..\n" + "Proje Adı: " + prj.ProjectName + "\nMüşteri: " + currentuser.ToString() +
                            "\nProje Yöneticisi: " + db.Users.Where(y => y.UsersID == prj.ProjectUserID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault());
                    }
                    else
                    {
                        MessageBox.Show("Boş Alanlar Mevcut..!");
                    }
                }
            }
            else
            {
                using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
                {
                    var currentuser = db.Users.Where(k => k.UsersID == kID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault();
                    if (TxtKontrol())
                    {
                        Projects prj = new Projects();
                        prj.ProjectName = txtPrjAd.Text;
                        prj.Budget = Convert.ToDecimal(String.Format("{0:c}", txtButce.Text));
                        prj.isActive = false;
                        prj.CreateUserID = kID;
                        prj.ProjectUserID = db.Users.Where(k => k.UserName + " " + k.UserSurname == cmbProjeLider.Text).Select(k => k.UsersID).FirstOrDefault();
                        prj.StartDate = Convert.ToDateTime(lblBasDate.Text);
                        prj.FinishDate = Convert.ToDateTime(lblEndDate.Text);

                        db.Projects.Add(prj);
                        db.SaveChanges();
                        MessageBox.Show("İsteğiniz Başarıyla Eklendi..\n" + "Proje Adı: " + prj.ProjectName + "\nMüşteri: " + currentuser.ToString() +
                            "\nProje Yöneticisi: " + db.Users.Where(y => y.UsersID == prj.ProjectUserID).Select(k => k.UserName + " " + k.UserSurname).FirstOrDefault());
                    }
                    else
                    {
                        MessageBox.Show("Boş Alanlar Mevcut..!");
                    }
                }
            }

        }
        public bool TxtKontrol()
        {
            if (txtPrjAd.Text == "" || lblBasDate.Text == "-" || lblEndDate.Text == "-" || txtButce.Text == "" || cmbProjeLider.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void frmMusteriPrjEkle_Load(object sender, EventArgs e)
        {
            dateBaslangic1.MinDate = DateTime.Now;
            dateBitis1.MinDate = DateTime.Now.AddDays(1);
            lblBasDate.Text = dateBaslangic1.MinDate.ToShortDateString();
            lblEndDate.Text = dateBitis1.MinDate.ToShortDateString();
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                foreach (var y in db.Users.Where(k => k.UserRole == 2).Select(k => k.UserName + " " + k.UserSurname))
                {
                    cmbProjeLider.Items.Add(y);
                }
            }
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {


                if (Pupdate == true)
                {
                    dateBaslangic1.MinDate =db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.StartDate).FirstOrDefault().Value;
                    txtPrjAd.BackColor = Color.Yellow;
                    txtPrjAd.Text = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.ProjectName).FirstOrDefault();
                    txtButce.Text = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.Budget).FirstOrDefault().ToString();
                    lblBasDate.Text = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.StartDate).FirstOrDefault().Value.ToShortDateString();
                    lblEndDate.Text = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.FinishDate).FirstOrDefault().Value.ToShortDateString();
                    dateBaslangic1.Value = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.StartDate).FirstOrDefault().Value;
                    dateBitis1.Value = db.Projects.Where(p => p.ProjectID == IDupdate).Select(s => s.FinishDate).FirstOrDefault().Value;
                    txtButce.BackColor = Color.Yellow;
                    cmbProjeLider.SelectedItem = db.Projects.Where(p => p.ProjectID == IDupdate).Select(y => y.Users1.UserName + " " + y.Users1.UserSurname).FirstOrDefault();

                }
            }

        }
        private void txtButce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateBitis1_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dateBitis1.Value.ToShortDateString();
        }

        private void dateBaslangic1_ValueChanged(object sender, EventArgs e)
        {
            lblBasDate.Text = dateBaslangic1.Value.ToShortDateString();
            dateBitis1.MinDate = dateBaslangic1.Value;
        }
    }
}