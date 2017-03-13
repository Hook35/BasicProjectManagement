using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManagement;

namespace YPYUnitTest
{
    [TestClass]
    public class SMTTest
    {

        [TestMethod]
        public void GirisTest()
        {
           
            {
                UserCreate uc = new UserCreate();
                bool result = uc.girisKontrol("omerB", "1234");
                Assert.AreEqual(false, result);
            }
        }
        [TestMethod]
        public void KayitTest()
        {
                UserCreate uc = new UserCreate();
                bool result = uc.kayit("Ali", "Can", "ali.can", "123ali", "Müşteri", DateTime.Now);
                Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void FarkTest()
        {
            frmProssesEkle form = new frmProssesEkle(1, "", 1);
            int result = form.GunFarki(DateTime.Now, DateTime.Now);
            Assert.AreEqual(0, result);

        }

      /*  [TestMethod]
        public void FormProjeEklemeTest()
        {
            frmMusteriPrjEkle form = new frmMusteriPrjEkle(1,true,20);
            int result = for
            Assert.AreEqual(0, result);

        }*/
    }

}
