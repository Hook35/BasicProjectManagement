using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public interface IUserCreate
    {
        bool girisKontrol(string kullaniciAdi, string sifre);
        bool kayit(string adi, string soyadi, string kullaniciAdi, string sifre, string kullaniciRolu, DateTime tarih);
       
    }
}
