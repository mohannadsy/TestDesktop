using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ultra.Views;
using Ultra.Views.Account;
using Ultra.Views.BranchAndUser;
using Ultra.Views.CostCenter;
using Ultra.Views.File;
using Ultra.Views.Store;

namespace Ultra
{
    public partial class Desktop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            //OpenFileUserControl openFile = new OpenFileUserControl();
            //openFile.Show();
            //openFile.Dock = DockStyle.Fill;
            //openFile.BringToFront();
            //openFile.SetBounds;

        }

        private void backstageViewTabItem2_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       
     

        private void barButtonItem80_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            TestForm.execute();
        }

        private void barButtonItemStoreGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new StoreForm().Show();
        }

        private void barButtonItemBranchesAndUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new BranchAndUserForm().Show();
        }

        private void barButtonItemCostCenter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new CostCenterForm().Show();
        }

        private void barButtonItemAccountGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AccountForm().Show();
        }
    }
}
