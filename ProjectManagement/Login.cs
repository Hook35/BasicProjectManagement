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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {

            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.ShowDialog();
        }

        private void btnlLogin_Click(object sender, EventArgs e)
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                string currentnick = db.Users.Where(k => k.UserNickname == txtNick.Text && k.UserPassword == txtPass.Text).Select(s => s.UserNickname).FirstOrDefault();
                string currentpass = db.Users.Where(k => k.UserNickname == txtNick.Text && k.UserPassword == txtPass.Text).Select(s => s.UserPassword).FirstOrDefault();
                if (currentnick==txtNick.Text && currentpass==txtPass.Text)
                {
                    int rol = db.Users.Where(k => k.UserNickname == txtNick.Text && k.UserPassword == txtPass.Text).Select(s => s.UserRole).FirstOrDefault().Value;
                    if (rol == 1)
                    {
                        frmMusteri musteri = new frmMusteri(txtNick.Text,this);
                        musteri.Show();
                    }
                    else if (rol == 2)
                    {
                        frmYonetici yonetici = new frmYonetici(txtNick.Text,this);
                        yonetici.Show();
                   
                    }
                    else if (rol>2)
                    {
                        Log.Giris(txtNick.Text, db.Users.Where(k => k.UserNickname == txtNick.Text).Select(s => s.UsersID).FirstOrDefault());
                        
                        frmCalisan calisan = new frmCalisan(txtNick.Text,this);
                        Log.LogEkle("\n<< Çalışan Ekranına Girildi >>\n");
                        calisan.Show();
                    }   
                }

                else
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Yok");
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = '*';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}