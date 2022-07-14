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

namespace Ultra.Views.Store
{
    public partial class StoreCardUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public StoreCardUserControl()
        {
            InitializeComponent();
            TabControl.TabPages.Remove(TabMix);
        }

        private void ComboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxAccountType.SelectedItem.ToString() == "تجميعي")
            {
                TabControl.TabPages.Remove(TabBasicInformation);
                TabControl.TabPages.Insert(0, TabMix);
                TabControl.SelectedIndex = 0;
            }
            if (ComboBoxAccountType.SelectedItem.ToString() == "عادي")
            {
                TabControl.TabPages.Remove(TabMix);
                TabControl.TabPages.Insert(0, TabBasicInformation);
                TabControl.SelectedIndex = 0;
             }
        }
    }
}
