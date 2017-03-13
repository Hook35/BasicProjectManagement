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
    public partial class frmProssesEkle : DevExpress.XtraEditors.XtraForm
    {
        int kID;
        int pId;
        int prosesID;
        bool updateP = false;
        public frmProssesEkle(int kID, string projead, int pId)
        {
            InitializeComponent();
            this.kID = kID;
            lblProjeAd.Text = projead;
            this.pId = pId;
        }
        public frmProssesEkle(int kID, string projead, int pId,int prosesID)
        {
            InitializeComponent();
            this.kID = kID;
            lblProjeAd.Text = projead;
            this.pId = pId;
            this.prosesID = prosesID;
        }
        public frmProssesEkle(int kID, string projead, int pId, int prosesID,bool up)
        {
            InitializeComponent();
            this.kID = kID;
            lblProjeAd.Text = projead;
            this.pId = pId;
            this.prosesID = prosesID;
            this.updateP = up;
            YazilimYonetimAraciEntities1 db=new YazilimYonetimAraciEntities1();
            txtSrcAd.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.ProcessName).FirstOrDefault().ToString();txtSrcAd.BackColor = Color.Yellow;
            
            lblBasDate.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.StartDate).FirstOrDefault().Value.ToShortDateString();
            dateBaslangic1.Value = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.StartDate).FirstOrDefault().Value;
            lblEndDate.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.FinishDate).FirstOrDefault().Value.ToShortDateString();
            dateBitis1.Value = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.FinishDate).FirstOrDefault().Value;
            txtSure.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.Duration).FirstOrDefault().ToString(); txtSure.BackColor = Color.Yellow;
            nmbOran.Value = Convert.ToDecimal(db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.CompleteRate).FirstOrDefault()); nmbOran.BackColor = Color.Yellow;
            cmbOncelik.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.Priority).FirstOrDefault().ToString(); cmbOncelik.BackColor = Color.Yellow;
            txtNot.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.Notes).FirstOrDefault(); txtNot.BackColor = Color.Yellow;
            txtAciklama.Text = db.Process.Where(p => p.ProcessID == prosesID).Select(pr => pr.Descriptions).FirstOrDefault(); txtAciklama.BackColor = Color.Yellow;
            btnSurecEkle.Text = "SÜREÇ GÜNCELLE";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();
            string kad = db.Users.Where(k => k.UsersID == kID).Select(u => u.UserNickname).FirstOrDefault();

            frmYonetici yntc = new frmYonetici(kad);
            yntc.Show();
        }
        
        public bool TxtKontrol()
        {
            if (txtSrcAd.Text == "" || lblBasDate.Text == "-" || lblEndDate.Text == "-" || cmbOncelik.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSurecEkle_Click(object sender, EventArgs e)
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                if (this.updateP == true)
                {
                    var upd_list = db.Process.Where(p => p.ProcessID == this.prosesID).FirstOrDefault();
                    upd_list.ProcessName = txtSrcAd.Text;
                    upd_list.StartDate = Convert.ToDateTime(lblBasDate.Text);
                    upd_list.FinishDate = Convert.ToDateTime(lblEndDate.Text);
                    upd_list.Duration = GunFarki(Convert.ToDateTime(lblBasDate.Text), Convert.ToDateTime(lblEndDate.Text));
                    upd_list.CompleteRate = Convert.ToInt32(nmbOran.Value);
                    upd_list.Priority = Convert.ToInt32(cmbOncelik.Text);
                    upd_list.Descriptions = txtAciklama.Text;
                    upd_list.Notes = txtNot.Text;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme işlemi Başarılı..");
                }
                else
                {

                    if (TxtKontrol())
                    {

                        Process process = new Process();
                        process.CreateUserID = kID;
                        process.ProcessName = txtSrcAd.Text;
                        process.StartDate = Convert.ToDateTime(lblBasDate.Text);
                        process.FinishDate = Convert.ToDateTime(lblEndDate.Text);
                        process.Duration = GunFarki(Convert.ToDateTime(lblBasDate.Text), Convert.ToDateTime(lblEndDate.Text));
                        process.CompleteRate = Convert.ToInt32(nmbOran.Value);
                        process.Priority = Convert.ToInt32(cmbOncelik.Text);
                        process.Descriptions = txtAciklama.Text;
                        process.Notes = txtNot.Text;
                        process.ProjectID = pId;

                        UserProcess up = new UserProcess();
                        up.UsersID = kID;

                        if (this.prosesID != 0)
                        {
                            process.ParentID = this.prosesID;
                            up.ProcessID = this.prosesID;
                            up.UserRolesID = db.UserRoles.Where(u => u.UserID == kID).Select(r => r.UserRolesID).FirstOrDefault();
                        }
                        else
                        {
                            process.ParentID = 0;
                        }


                        db.Process.Add(process);
                        db.SaveChanges();
                        MessageBox.Show(process.ProcessName + " | Süreç Eklema Başarılı..");



                    }
                    else
                    {
                        MessageBox.Show("Boş Alanlar Mevcut..!");
                    }
                }
            }
        }
        public int GunFarki(DateTime d1, DateTime d2)
        {
            TimeSpan zaman = new TimeSpan();
            zaman = d1 - d2;
            int sure = Math.Abs(zaman.Days);
            return sure;

        }

        private void frmProssesEkle_Load(object sender, EventArgs e)
        {
            dateBaslangic1.MinDate = DateTime.Now;
            dateBitis1.MinDate = DateTime.Now.AddDays(1);

            lblBasDate.Text = dateBaslangic1.MinDate.ToShortDateString();
            lblEndDate.Text = dateBitis1.MinDate.ToShortDateString();

            txtSure.Text = GunFarki(dateBitis1.Value, dateBaslangic1.Value).ToString();
            
        }

        private void dateBaslangic1_ValueChanged(object sender, EventArgs e)
        {
            lblBasDate.Text = dateBaslangic1.Value.ToShortDateString();
            dateBitis1.MinDate = dateBaslangic1.Value;

        }

        private void dateBitis1_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dateBitis1.Value.ToShortDateString();
            txtSure.Text = GunFarki(dateBitis1.Value ,dateBaslangic1.Value).ToString();
            
        }


    }
}