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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace ProjectManagement
{
    public partial class frmCalisan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Login LoginBack;
        string kullaniciAd;
        int kID;
        public frmCalisan(string kAD,Login l)
        {
            InitializeComponent();
            this.LoginBack = l;
            this.kullaniciAd = kAD;

            YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1();

            this.Text = db.Users.Where(k => k.UserNickname == kAD).Select(k =>k.UserName+" "+k.UserSurname).FirstOrDefault() +" | Çalışan Paneli";
            this.kID = db.Users.Where(k => k.UserNickname == kAD).Select(k => k.UsersID).FirstOrDefault();
        }
        private void CreateColumns(TreeList tl)
        {
            // Create three columns.
            tl.BeginUpdate();
            tl.Columns.Add();
            tl.Columns[0].Caption = "Süreçler";
            tl.Columns[0].VisibleIndex = 0;
            tl.Columns.Add();
            tl.Columns[1].Caption = "Proje Adı";
            tl.Columns[1].VisibleIndex = 1;
            tl.Columns.Add();
            tl.Columns[2].Caption = "Başlangıç Tarihi";
            tl.Columns[2].VisibleIndex = 2;
            tl.Columns.Add();
            tl.Columns[3].Caption = "Bitiş Tarihi";
            tl.Columns[3].VisibleIndex = 3;
            tl.Columns.Add();
            tl.Columns[4].Caption = "Tamamlanma Oranı";
            tl.Columns[4].VisibleIndex = 4;

            tl.EndUpdate();
        }
        private void CreateNodes(TreeList tl)
        {
            using (YazilimYonetimAraciEntities1 db = new YazilimYonetimAraciEntities1())
            {
                List<WorkFollow> isler = new List<WorkFollow>();
                isler = db.WorkFollow.Where(k => k.UserID == kID).ToList();

                foreach (var item in isler.Where(k => k.UserID == kID).GroupBy(wf => wf.ProcessID).Select(group => group.FirstOrDefault()).ToList())
                {
                    tl.BeginUnboundLoad();

                    TreeListNode parentForRootNodes = null;
                    TreeListNode rootNode = tl.AppendNode(
                        new object[] { item.Process.ProcessName, item.Process.Projects.ProjectName, item.StartDate.Value.ToShortDateString(), item.FinishDate.Value.ToShortDateString(), "% "+item.CompleteRate},
                        parentForRootNodes);
                    
                    tl.AppendNode(new object[]{ "Atanan Görev","Tamamlanma Oranı" },rootNode);

                    foreach (var w in isler.Where(w=>w.ProcessID==item.ProcessID).ToList())
                    {
                        tl.AppendNode(new object[] { w.WorkFollowDetails.WorkFollowName,"% "+w.CompleteRate.ToString() }, rootNode);
                    }
                   
                    tl.EndUnboundLoad();
                }

            }

        }
        private void frmCalisan_Load(object sender, EventArgs e)
        {
            CreateColumns(lstCalisanPrj);
            CreateNodes(lstCalisanPrj);
        }

        private void btnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Log.LogEkle("<< Çıkış Yapıldı >>");
            Log.Cikis();
            if (LoginBack!=null)
            {
                
                this.Close();
                LoginBack.Show();
                
            }
            else
            {
                this.Close();
                LoginBack  = new Login();
                LoginBack.Show();
            }
        }

        private void lstCalisanPrj_ShownEditor(object sender, EventArgs e)
        {
            ((TreeList)sender).ActiveEditor.Properties.ReadOnly = true;
        }

    }
}