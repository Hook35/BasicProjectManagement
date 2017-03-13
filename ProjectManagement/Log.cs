using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace ProjectManagement
{
    public static class Log
    {
        public static string log = "";
        public static int CurrentID;
        public static string giris = "";
        public static string cikis = "";
        
        public static void Giris(string kullaniciadi,int KID)
        {
            log = DateTime.Now.ToString() + "----" + kullaniciadi + "------"+Environment.NewLine;
            giris = DateTime.Now.ToString();
            CurrentID = KID;
        }
        public static void LogEkle(string content)
        {
            log += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + content + Environment.NewLine;
        }
        public static void Cikis()
        {
            cikis = DateTime.Now.ToString();
            using (YazilimYonetimAraciEntities1 db=new YazilimYonetimAraciEntities1())
            {
                UserLogDetails ul = new UserLogDetails();
                UserLogs u_l=new UserLogs();
                ul.LogDate = DateTime.Now;
                ul.UserLogName = "Giriş: " + giris + Environment.NewLine + " | Çıkış: " + cikis + Environment.NewLine;
                u_l.UserLogDetails.Add(ul);
                db.Users.Where(u => u.UsersID == CurrentID).FirstOrDefault().UserLogs.Add(u_l);
          
                db.SaveChanges();
            }
            

            yaz(log);
            
            log = "";
            CurrentID = 0;
            giris = "";
            cikis = "";
        }
        
        private static void yaz(string logg)
        {
            TextWriter dosya = new StreamWriter(@""+Environment.CurrentDirectory + CurrentID + ".txt");
            
            try
            {
                dosya.WriteLine(logg);
            }
            finally
            {
                dosya.Flush();
                dosya.Close();
            }
        }
    }
}
