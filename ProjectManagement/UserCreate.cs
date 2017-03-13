using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public class UserCreate:IUserCreate
    {

        public bool girisKontrol(string kullaniciAdi, string sifre)
        {
            using (YazilimYonetimAraciEntities1 smt = new YazilimYonetimAraciEntities1())
            {
                string kAdi = smt.Users.Where(w => w.UserNickname == kullaniciAdi).Select(s => s.UserNickname).FirstOrDefault();
                string sfr = smt.Users.Where(w => w.UserPassword == sifre).Select(s => s.UserPassword).FirstOrDefault();
                if (kAdi == null || sfr == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public bool kayit(string adi, string soyadi, string kullaniciAdi, string sifre, string kullaniciRolu, DateTime tarih)
        {
            using (YazilimYonetimAraciEntities1 smt = new YazilimYonetimAraciEntities1())
            {
                Users user = new Users();

                string kAdi = smt.Users.Where(w => w.UserNickname == kullaniciAdi).Select(s => s.UserNickname).FirstOrDefault();
                if (kAdi != null)
                {
                    return false;
                }
                else
                {
                    user.UserName = adi;
                    user.UserSurname = soyadi;
                    user.UserNickname = kullaniciAdi;
                    user.UserPassword = sifre;
                    user.UserRole = Convert.ToInt32(smt.RoleNames.Where(k=>k.RoleName==kullaniciRolu).Select(k=>k.RoleNameID).FirstOrDefault());
                    user.UserCreatedDate = tarih;
                    smt.Users.Add(user);
                    smt.SaveChanges();

                    //rol kayıt
                    UserRoles ur = new UserRoles();
                    ur.UserID = user.UsersID;
                    ur.RoleNameID = user.UserRole;
                    smt.UserRoles.Add(ur);
                    smt.SaveChanges();
                    return true;

                }

            }     
        }


        
    }
}
