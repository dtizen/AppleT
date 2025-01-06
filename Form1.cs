using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void recentItemControl2_SelectedTabChanged(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {

        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem8_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            // 새로운 Form2 인스턴스 생성
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            // Form2를 보여줍니다.
            form2.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 2;
        }
    }
}
