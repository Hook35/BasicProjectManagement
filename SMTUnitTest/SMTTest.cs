using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManagement;

namespace SMTUnitTest
{
    [TestClass]
    public class SMTTest

    {
        [TestMethod]
        public void GirisTest()
        {
            UserCreate uc = new UserCreate();
           bool result= uc.girisKontrol("omerB","1234");
           Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void KayitTest()
        {
            UserCreate uc = new UserCreate();
            bool result= uc.kayit("Ömer", "Batır", "omer.batir", "123omerbatir", "Müşteri", DateTime.Now);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void FarkTest()
        {
            frmProssesEkle form = new frmProssesEkle(1,"",1);
            int result= form.GunFarki(DateTime.Now,DateTime.Now);
            Assert.AreEqual(0, result);

        }

    }
}
