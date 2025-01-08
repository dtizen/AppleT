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
            this.xtraTabControl1.SelectedTabPageIndex = 0;
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
            //this.xtraTabControl1.SelectedTabPageIndex = 7;
            //this.xtraTabControl2.SelectedTabPageIndex = 0;
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 0;
            this.groupControl1.ShowCaption = true;
            this.groupControl2.ShowCaption = false;
            this.groupControl3.ShowCaption = false;
           
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 6;
            this.xtraTabControl2.SelectedTabPageIndex = 0;
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 0;
            this.groupControl1.ShowCaption = true;
            this.groupControl2.ShowCaption = false;
            this.groupControl3.ShowCaption = false;
           
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Cut process is finished.");
            this.xtraTabControl1.SelectedTabPageIndex = 3;
        }

       

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 6;
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 1;
            this.groupControl1.ShowCaption = false;
            this.groupControl2.ShowCaption = true;
            this.groupControl3.ShowCaption = false;
            
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 2;
            this.groupControl1.ShowCaption = false;
            this.groupControl2.ShowCaption = false;
            this.groupControl3.ShowCaption = true;
           
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 10;
           
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 4;
            this.groupControl1.ShowCaption = false;
            this.groupControl2.ShowCaption = false;
            this.groupControl3.ShowCaption = false;
           
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 9;
            //this.xtraTabControl2.SelectedTabPageIndex = 4;
            this.groupControl1.ShowCaption = false;
            this.groupControl2.ShowCaption = false;
            this.groupControl3.ShowCaption = false;
          
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 11;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 8;
            this.xtraTabControl3.SelectedTabPageIndex = 0;
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 8;
            this.xtraTabControl3.SelectedTabPageIndex = 1;
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 5;
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xtraTabControl4.SelectedTabPageIndex = 0;
            this.xtraTabControl1.SelectedTabPageIndex = 9;
        }
    }
}
