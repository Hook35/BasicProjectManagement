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
    public partial class Kayit : DevExpress.XtraEditors.XtraForm
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool txtCont()
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtKullaniciAd.Text == "" || cmbKullaniciRol.Text == "" || txtPass.Text == "" || txtPassRep.Text == "")
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (ParolaCont())
            {
                if (txtCont()==false)
                {
                    MessageBox.Show("Boş Alanlar Mevcut...");
                }

                else
                {
                    string ad = txtAd.Text;
                    string soyad = txtSoyad.Text;
                    string kullaniciAdi = txtKullaniciAd.Text;
                    string rol = cmbKullaniciRol.Text;
                    string sifre = txtPass.Text;
                    DateTime tarih = DateTime.Now.ToLocalTime();
                    UserCreate kayit = new UserCreate();
                    if (kayit.kayit(ad, soyad, kullaniciAdi, sifre, rol, tarih))
                    {
                        MessageBox.Show("Kayıt Başarılı!");
                    }
                    else
                        MessageBox.Show("Böyle Bir Kullanici Adi Zaten Var!");
                }
            }
            else
                MessageBox.Show("Şifre Aynı Değil!");
        }

        private void txtPassRep_KeyUp(object sender, KeyEventArgs e)
        {
            ParolaCont();
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            ParolaCont();
        }

        public bool ParolaCont()
        {
            if (txtPass.Text != txtPassRep.Text)
            {
                lblCont.ForeColor = Color.Red;
                lblCont.Text = "*Parolalar Uyuşmuyor";
                return false;
            }
            else
            {
                lblCont.ForeColor = Color.Black;
                lblCont.Text = "-";
                return true;
            }
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                foreach (var item in db.RoleNames)
                {
                    cmbKullaniciRol.Items.Add(item.RoleName);
                }
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}