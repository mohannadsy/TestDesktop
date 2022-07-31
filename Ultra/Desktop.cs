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
using Ultra.Views.CostCenterDev;
using Ultra.Views.File;
using Ultra.Views.MaterialCard;
using Ultra.Views.Store;


using System.Globalization;
using System.Resources;
using System.Threading;


namespace Ultra
{
    public partial class Desktop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            // declare culture info

        public Desktop()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
        }

        private void switchLanguage()
        {
            Properties.Settings.Default.language = Properties.Settings.Default.language == "en-US" ? "ar" : "en-US";
            Properties.Settings.Default.Save();
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

        private void barButtonItemMaterialCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemMaterialsAndCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new CategoryAndMaterialForm().Show();
        }

        private void barButtonItemTestCostCenterDev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new CostCenterDev().Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchLanguage();
            Application.Restart();
        }
    }
}
