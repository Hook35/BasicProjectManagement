using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ProjectManagement
{
    public partial class frmIsTakibi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int kID;
        string prosesAD;
        int prosesID;
        string projeAD;
        public frmIsTakibi(int kID, string prosesAD, int prosesID, string projeAD)
        {
            InitializeComponent();
            this.kID = kID;
            this.prosesAD = prosesAD;
            this.prosesID = prosesID;
            this.projeAD = projeAD;
        }

        private void btnKaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(cmbKontrol())
            { 
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                //ANALİZ
                WorkFollow wfAnaliz = new WorkFollow();
                wfAnaliz.WorkFollowDetailsID = 1;
                wfAnaliz.ProcessID = prosesID;
                wfAnaliz.StartDate = dtAnaliz.Value;
                wfAnaliz.FinishDate = dtBAnaliz.Value;
                wfAnaliz.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbAnaliz.Text).Select(k => k.UsersID).FirstOrDefault();
                wfAnaliz.CompleteRate = Convert.ToInt32(nmbAnaliz.Value);
                db.WorkFollow.Add(wfAnaliz);
                db.SaveChanges();

                //TABLE
                WorkFollow wfTable = new WorkFollow();
                wfTable.WorkFollowDetailsID = 2;
                wfTable.ProcessID = prosesID;
                wfTable.StartDate = dtTable.Value;
                wfTable.FinishDate = dtBTable.Value;
                wfTable.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbTable.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTable.CompleteRate = Convert.ToInt32(nmbTable.Value);
                db.WorkFollow.Add(wfTable);
                db.SaveChanges();

                //PROC
                WorkFollow wfProc = new WorkFollow();
                wfProc.WorkFollowDetailsID = 3;
                wfProc.ProcessID = prosesID;
                wfProc.StartDate = dtProc.Value;
                wfProc.FinishDate = dtBProc.Value;
                wfProc.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbProc.Text).Select(k => k.UsersID).FirstOrDefault();
                wfProc.CompleteRate = Convert.ToInt32(nmbProc.Value);
                db.WorkFollow.Add(wfProc);
                db.SaveChanges();

                

                //DLL LİSTE
                WorkFollow wfDLLliste = new WorkFollow();
                wfDLLliste.WorkFollowDetailsID = 4;
                wfDLLliste.ProcessID = prosesID;
                wfDLLliste.StartDate = dtDllL.Value;
                wfDLLliste.FinishDate = dtBDllL.Value;
                wfDLLliste.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbDllL.Text).Select(k => k.UsersID).FirstOrDefault();
                wfDLLliste.CompleteRate = Convert.ToInt32(nmbDllL.Value);
                db.WorkFollow.Add(wfDLLliste);
                db.SaveChanges();

                //DLL İŞLEM
                WorkFollow wfDLLIslem = new WorkFollow();
                wfDLLIslem.WorkFollowDetailsID = 5;
                wfDLLIslem.ProcessID = prosesID;
                wfDLLIslem.StartDate = dtDllI.Value;
                wfDLLIslem.FinishDate = dtBDllI.Value;
                wfDLLIslem.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbDllIs.Text).Select(k => k.UsersID).FirstOrDefault();
                wfDLLIslem.CompleteRate = Convert.ToInt32(nmbDllI.Value);
                db.WorkFollow.Add(wfDLLIslem);
                db.SaveChanges();

                //ARAYÜZ
                WorkFollow wfArayuz = new WorkFollow();
                wfArayuz.WorkFollowDetailsID = 6;
                wfArayuz.ProcessID = prosesID;
                wfArayuz.StartDate = dtArayuz.Value;
                wfArayuz.FinishDate = dtBArayuz.Value;
                wfArayuz.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbArayuz.Text).Select(k => k.UsersID).FirstOrDefault();
                wfArayuz.CompleteRate = Convert.ToInt32(nmbArayuz.Value);
                db.WorkFollow.Add(wfArayuz);
                db.SaveChanges();

                //TEST1
                WorkFollow wfTest_1 = new WorkFollow();
                wfTest_1.WorkFollowDetailsID = 7;
                wfTest_1.ProcessID = prosesID;
                wfTest_1.StartDate = dtT1.Value;
                wfTest_1.FinishDate = dtBT1.Value;
                wfTest_1.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbT1.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTest_1.CompleteRate = Convert.ToInt32(nmbT1.Value);
                db.WorkFollow.Add(wfTest_1);
                db.SaveChanges();

                //TEST2
                WorkFollow wfTest_2 = new WorkFollow();
                wfTest_2.WorkFollowDetailsID = 8;
                wfTest_2.ProcessID = prosesID;
                wfTest_2.StartDate = dtT2.Value;
                wfTest_2.FinishDate = dtBT2.Value;
                wfTest_2.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbT2.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTest_2.CompleteRate = Convert.ToInt32(nmbT2.Value);
                db.WorkFollow.Add(wfTest_2);
                db.SaveChanges();

                //TEST3 
                WorkFollow wfTest_3 = new WorkFollow();
                wfTest_3.WorkFollowDetailsID = 9;
                wfTest_3.ProcessID = prosesID;
                wfTest_3.StartDate = dtT3.Value;
                wfTest_3.FinishDate = dtBT3.Value;
                wfTest_3.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbT3.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTest_3.CompleteRate = Convert.ToInt32(nmbT3.Value);
                db.WorkFollow.Add(wfTest_3);
                db.SaveChanges();


                //TEST4
                WorkFollow wfTest_4 = new WorkFollow();
                wfTest_4.WorkFollowDetailsID = 10;
                wfTest_4.ProcessID = prosesID;
                wfTest_4.StartDate = dtT4.Value;
                wfTest_4.FinishDate = dtBT4.Value;
                wfTest_4.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbT4.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTest_4.CompleteRate = Convert.ToInt32(nmbT4.Value);
                db.WorkFollow.Add(wfTest_4);
                db.SaveChanges();

                //TEST5 
                WorkFollow wfTest_5 = new WorkFollow();
                wfTest_5.WorkFollowDetailsID = 11;
                wfTest_5.ProcessID = prosesID;
                wfTest_5.StartDate = dtT5.Value;
                wfTest_5.FinishDate = dtBT5.Value;
                wfTest_5.UserID = db.Users.Where(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault() == cmbT5.Text).Select(k => k.UsersID).FirstOrDefault();
                wfTest_5.CompleteRate = Convert.ToInt32(nmbT5.Value);
                db.WorkFollow.Add(wfTest_5);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi...");
                


            }
            }
            else
            {
                MessageBox.Show("Lütfen Kişileri Boş Bırakmayın...");
            }
        }
        public void Tarih()
        {
            dtAnaliz.MinDate = DateTime.Now;
            dtBAnaliz.MinDate = DateTime.Now.AddDays(1);
            dtTable.MinDate = DateTime.Now;
            dtBTable.MinDate = DateTime.Now.AddDays(1);
            dtProc.MinDate = DateTime.Now;
            dtBProc.MinDate = DateTime.Now.AddDays(1);
            dtDllL.MinDate = DateTime.Now;
            dtBDllL.MinDate = DateTime.Now.AddDays(1);
            dtDllI.MinDate = DateTime.Now;
            dtBDllI.MinDate = DateTime.Now.AddDays(1);
            dtArayuz.MinDate = DateTime.Now;
            dtBArayuz.MinDate = DateTime.Now.AddDays(1);
            dtT1.MinDate = DateTime.Now;
            dtBT1.MinDate = DateTime.Now.AddDays(1);
            dtT2.MinDate = DateTime.Now;
            dtBT2.MinDate = DateTime.Now.AddDays(1);
            dtT3.MinDate = DateTime.Now;
            dtBT3.MinDate = DateTime.Now.AddDays(1);
            dtT4.MinDate = DateTime.Now;
            dtBT4.MinDate = DateTime.Now.AddDays(1);
            dtT5.MinDate = DateTime.Now;
            dtBT5.MinDate = DateTime.Now.AddDays(1);
        }
        private void frmIsTakibi_Load(object sender, EventArgs e)
        {
            lblPrjAd.Text = projeAD;
            lblSurec.Text = prosesAD;
            Tarih();

            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                List<Users> users = db.Users.Where(k => k.UserRole > 2).ToList();
                List<RoleNames> rols = db.RoleNames.ToList();
                foreach (var item in users)
                {
                    rols.Add(rols.Where(r => r.RoleNameID == item.UserRole).FirstOrDefault());
                }
                List<Users> n_users = new List<Users>();

                foreach (var y in users.Select(k => k.UserName + " " + k.UserSurname + " - " + db.RoleNames.Where(r => r.RoleNameID == k.UserRole).Select(ro => ro.RoleName).FirstOrDefault()))
                {
                    cmbAnaliz.Properties.Items.Add(y);
                    cmbTable.Properties.Items.Add(y);
                    cmbProc.Properties.Items.Add(y);
                    cmbDllL.Properties.Items.Add(y);
                    cmbDllIs.Properties.Items.Add(y);
                    cmbArayuz.Properties.Items.Add(y);
                    cmbT1.Properties.Items.Add(y);
                    cmbT2.Properties.Items.Add(y);
                    cmbT3.Properties.Items.Add(y);
                    cmbT4.Properties.Items.Add(y);
                    cmbT5.Properties.Items.Add(y);
                }
            }
        }

        public bool cmbKontrol()
        {
            if (cmbAnaliz.Text==""||cmbArayuz.Text==""||cmbDllIs.Text==""||cmbDllL.Text==""||cmbProc.Text==""||cmbTable.Text==""||cmbT1.Text==""||cmbT2.Text==""||cmbT3.Text==""||cmbT4.Text==""||cmbT5.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGeri_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnYazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            printDocument1.Print();
        }
      
        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        
 
        private int[] FindColumnWidths(Graphics gr, Font header_font, Font body_font, string[] headers, string[,] values)
        {
          
            int[] widths = new int[headers.Length];

           
            for (int col = 0; col < widths.Length; col++)
            {
              
                widths[col] = (int)gr.MeasureString(headers[col], header_font).Width;

              
                for (int row = 0; row <= values.GetUpperBound(0); row++)
                {
                    int value_width = (int)gr.MeasureString(values[row, col], body_font).Width;
                    if (widths[col] < value_width) widths[col] = value_width;
                }

                
                widths[col] += 20;
            }

            return widths;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                   string[] Headers = {"İş", "Çözümleyen", "Başlangıç Tarihi", "Bitiş Tarihi", "Oran(%)"};
                   string[,] Data =
            {
                {"Analiz",cmbAnaliz.Text, dtAnaliz.Value.ToShortDateString(), dtBAnaliz.Value.ToShortDateString(), nmbAnaliz.Value.ToString()},
                {"Table",cmbTable.Text, dtTable.Value.ToShortDateString(), dtBTable.Value.ToShortDateString(), nmbTable.Value.ToString()},
                {"Procedure",cmbProc.Text,dtProc.Value.ToShortDateString(), dtBProc.Value.ToShortDateString(), nmbProc.Value.ToString()},
                {"DLL List",cmbDllL.Text, dtDllL.Value.ToShortDateString(), dtBDllL.Value.ToShortDateString(), nmbDllL.Value.ToString()},
                {"DLL İşlem",cmbDllIs.Text, dtDllI.Value.ToShortDateString(), dtBDllI.Value.ToShortDateString(), nmbDllI.Value.ToString()},
                {"Arayüz",cmbArayuz.Text, dtArayuz.Value.ToShortDateString(), dtBArayuz.Value.ToShortDateString(), nmbArayuz.Value.ToString()},
                {"Test 1",cmbT1.Text, dtT1.Value.ToShortDateString(), dtBT1.Value.ToShortDateString(), nmbT1.Value.ToString()},
                {"Test 2",cmbT2.Text, dtT2.Value.ToShortDateString(), dtBT2.Value.ToShortDateString(), nmbT2.Value.ToString()},
                {"Test 3",cmbT3.Text, dtT3.Value.ToShortDateString(), dtBT3.Value.ToShortDateString(), nmbT3.Value.ToString()},
                {"Test 4",cmbT4.Text,dtT4.Value.ToShortDateString(), dtBT4.Value.ToShortDateString(), nmbT4.Value.ToString()},
                {"Test 5",cmbT5.Text, dtT5.Value.ToShortDateString(), dtBT5.Value.ToShortDateString(), nmbT5.Value.ToString()},
            };
           
            using (Font header_font = new Font("Times New Roman", 16, FontStyle.Bold))
            {
                using (Font body_font = new Font("Times New Roman", 12))
                {
                    
                    int line_spacing = 20;

                  
                    int[] column_widths = FindColumnWidths(
                        e.Graphics, header_font, body_font, Headers, Data);

                   
                    int x = e.MarginBounds.Left-45;

                    e.Graphics.DrawString("PROJE: "+lblPrjAd.Text, new Font("Times New Roman", 20,FontStyle.Bold), Brushes.Black,50,50);
                    e.Graphics.DrawString("SÜREÇ: "+lblSurec.Text, new Font("Times New Roman", 18,FontStyle.Bold), Brushes.Black, 50, 90);
                    e.Graphics.DrawString("-------------------------------------------------------------------------------------", 
                    new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, 50, 111);
                    for (int col = 0; col < Headers.Length; col++)
                    {
                        
                       
                        int y = e.MarginBounds.Top;
                        e.Graphics.DrawString(Headers[col],
                            header_font, Brushes.Blue, x, y+30);
                        y += (int)(line_spacing * 1.5)+30;

                        
                        for (int row = 0; row <= Data.GetUpperBound(0); row++)
                        {
                            if (col==0 && row>=0)
                            {
                                e.Graphics.DrawString(Data[row, col]+":", body_font, Brushes.Blue, x, y);
                                y += line_spacing;
                            }
                            else
                            {
                                e.Graphics.DrawString(Data[row, col], body_font, Brushes.Black, x, y);
                                y += line_spacing;
                            }
                        }

                        
                        x += column_widths[col];
                    } 
                } 
            } 

           
            e.HasMorePages = false;
        }

        private void nmbAnaliz_ValueChanged(object sender, EventArgs e)
        {
            P1.Value = Convert.ToInt32(nmbAnaliz.Value);
        }

        private void nmbTable_ValueChanged(object sender, EventArgs e)
        {
            P2.Value = Convert.ToInt32(nmbTable.Value);
        }

        private void nmbProc_ValueChanged(object sender, EventArgs e)
        {
            P3.Value = Convert.ToInt32(nmbProc.Value);
        }

        private void nmbDllL_ValueChanged(object sender, EventArgs e)
        {
            P4.Value = Convert.ToInt32(nmbDllL.Value);
        }

        private void nmbDllI_ValueChanged(object sender, EventArgs e)
        {
            P5.Value = Convert.ToInt32(nmbDllI.Value);
        }

        private void nmbArayuz_ValueChanged(object sender, EventArgs e)
        {
            P6.Value = Convert.ToInt32(nmbArayuz.Value);
        }

        private void nmbT1_ValueChanged(object sender, EventArgs e)
        {
            P7.Value = Convert.ToInt32(nmbT1.Value);
        }

        private void nmbT2_ValueChanged(object sender, EventArgs e)
        {
            P8.Value = Convert.ToInt32(nmbT2.Value);
        }

        private void nmbT3_ValueChanged(object sender, EventArgs e)
        {
            P9.Value = Convert.ToInt32(nmbT3.Value);
        }

        private void nmbT4_ValueChanged(object sender, EventArgs e)
        {
            P10.Value = Convert.ToInt32(nmbT4.Value);
        }

        private void nmbT5_ValueChanged(object sender, EventArgs e)
        {
            P11.Value = Convert.ToInt32(nmbT5.Value);
        }
    }
}