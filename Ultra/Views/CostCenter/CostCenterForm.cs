using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Resources;
using System.Threading;

namespace Ultra.Views.CostCenter
{
    public partial class CostCenterForm : DevExpress.XtraEditors.XtraForm
    {

        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            // declare culture info


        public CostCenterForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CultureInfo.GetCultures(CultureTypes.NeutralCultures)[0].Name);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
        }

        private void CostCenterForm_Load(object sender, EventArgs e)
        {

        }

        private void switchLanguage()
        {
            Properties.Settings.Default.language = Properties.Settings.Default.language == "en" ? "ar" : "en";
            Properties.Settings.Default.Save();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            switchLanguage();
            Application.Restart();
        }

        private void treeList1_FocusedNodeChanged_1(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new CostCardUserControlLocalizable());
            //zekra
            //if (Properties.Settings.Default.language == "ar")
            //    PanelMain.Controls.Clear();
            //PanelMain.Controls.Add(new CostCardUserContolArabic());
            //zekra

            //CostCenterCardForm costCenterForm = new CostCenterCardForm();
            //costCenterForm.TopLevel = false;
            //PanelMain.Controls.Add(costCenterForm);
            //costCenterForm.BringToFront();
            //costCenterForm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new CostCardUserControlLocalizable());
        }
    }
}