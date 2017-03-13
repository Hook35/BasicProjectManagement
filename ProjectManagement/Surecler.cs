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
    public partial class Surecler : DevExpress.XtraEditors.XtraForm
    {
        int prjID;
        int kID;
        string prjAd;
        public Surecler(int kID, int ProjeID, string prjAd)
        {
            InitializeComponent();
            this.prjID = ProjeID;
            lblProjeAd.Text = prjAd + " - Süreçler";
            this.kID = kID;
            this.prjAd = prjAd;
        }

        private void Surecler_Load(object sender, EventArgs e)
        {
            ListeDoldur();

        }
        private void ListeDoldur()
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                List<Process> surecler = new List<Process>();
                surecler = db.Process.Where(k => k.ProjectID == prjID).ToList();

                List<Process> ana_surecler = new List<Process>();
                ana_surecler = db.Process.Where(k => k.ProjectID == prjID && k.ParentID == 0).ToList();

                chxAktiflik.Checked = db.Projects.Where(p => p.ProjectID == prjID).Select(s => s.isActive.Value).FirstOrDefault();

                int gecici = 0;
                for (int i = 0; i < ana_surecler.Count; i++)
                {
                    List<Process> alt_surecler = new List<Process>();
                    alt_surecler = surecler.Where(p => p.ParentID == ana_surecler[i].ProcessID).ToList();

                    lstProsses.Items.Add(ana_surecler[i].ProcessName);
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].StartDate.Value.ToShortDateString());
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].FinishDate.Value.ToShortDateString());
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].Duration.ToString());
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].CompleteRate.ToString());
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].Priority.ToString());
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].Notes);
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].Descriptions);
                    lstProsses.Items[i + gecici].SubItems.Add(ana_surecler[i].ProcessID.ToString());


                    //ALT SÜREÇLER
                    if (alt_surecler != null)
                    {
                        for (int j = 0; j < alt_surecler.Count; j++)
                        {
                            lstProsses.Items.Add("      " + alt_surecler[j].ProcessName);
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].StartDate.Value.ToShortDateString());
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].FinishDate.Value.ToShortDateString());
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].Duration.ToString());
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].CompleteRate.ToString());
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].Priority.ToString());
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].Notes);
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].Descriptions);
                            lstProsses.Items[i + gecici + 1].SubItems.Add(alt_surecler[j].ProcessID.ToString());

                            gecici++;
                        }

                    }




                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();
            string kad = db.Users.Where(k => k.UsersID == kID).Select(u => u.UserNickname).FirstOrDefault();
            frmYonetici yntc = new frmYonetici(kad);
            yntc.Show();
        }

        private void btnAltSurecEkle_Click(object sender, EventArgs e)
        {
            if (lstProsses.SelectedItems.Count != 0)
            {
                int seciliid = lstProsses.Items.IndexOf(lstProsses.SelectedItems[0]);

                string prosesAd = lstProsses.Items[seciliid].Text;

                int seciliPrjID = Convert.ToInt32(lstProsses.Items.IndexOf(lstProsses.FocusedItem));
                int prosesId = Convert.ToInt32(lstProsses.Items[seciliPrjID].SubItems[8].Text);

                YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();
                if (db.Process.Where(p => p.ProcessID == prosesId).Select(pro => pro.ParentID).FirstOrDefault() != 0)
                {
                    MessageBox.Show("Seçilen süreç zaten 'alt süreç' olarak sistemde mevcut..");
                }
                else
                {
                    this.Close();
                    frmProssesEkle pr = new frmProssesEkle(kID, prosesAd, prjID, prosesId);
                    pr.Show();
                }
            }
            else
            {
                MessageBox.Show("Bir Süreç Seçiniz..!");
            }

        }

        private void btnIsTakibi_Click(object sender, EventArgs e)
        {
            if (lstProsses.SelectedItems.Count != 0)
            {
                int seciliid = lstProsses.Items.IndexOf(lstProsses.SelectedItems[0]);
                string prosesAd = lstProsses.Items[seciliid].Text;

                int seciliPrjID = Convert.ToInt32(lstProsses.Items.IndexOf(lstProsses.FocusedItem));
                int prosesId = Convert.ToInt32(lstProsses.Items[seciliPrjID].SubItems[8].Text);

            
                    frmIsTakibi wf = new frmIsTakibi(kID, prosesAd, prosesId, prjAd);
                    wf.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bir Süreç Seçiniz..!");
            }
        }

        private void btnAltSurecDuzenle_Click(object sender, EventArgs e)
        {
            if (lstProsses.SelectedItems.Count != 0)
            {
                int seciliid = lstProsses.Items.IndexOf(lstProsses.SelectedItems[0]);

                string prosesAd = lstProsses.Items[seciliid].Text;

                int seciliPrjID = Convert.ToInt32(lstProsses.Items.IndexOf(lstProsses.FocusedItem));
                int prosesId = Convert.ToInt32(lstProsses.Items[seciliPrjID].SubItems[8].Text);

                YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();


                this.Close();
                frmProssesEkle pr = new frmProssesEkle(kID, prosesAd, prjID, prosesId, true);
                pr.Show();

            }
            else
            {
                MessageBox.Show("Bir Süreç Seçiniz..!");
            }
        }

        private void chxAktiflik_CheckedChanged(object sender, EventArgs e)
        {
            int seciliPrjID = Convert.ToInt32(lstProsses.Items.IndexOf(lstProsses.FocusedItem));

            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();
            var upd_list = db.Projects.Where(p => p.ProjectID == prjID).FirstOrDefault();
            upd_list.isActive = chxAktiflik.Checked;
            chxAktiflik.ForeColor = upd_list.isActive.Value ? Color.Green : Color.Red;
            db.SaveChanges();


        }




    }
}