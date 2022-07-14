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

namespace Ultra.Views.Account
{
    public partial class AccountCardUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public AccountCardUserControl()
        {
            InitializeComponent();

            TabControl.TabPages.Remove(TabCleintInformation);
            TabControl.TabPages.Remove(TabCleintOptions);

            TabControl.TabPages.Remove(TabFinal);
            TabControl.TabPages.Remove(TabMix);
            TabControl.TabPages.Remove(TabDist);
            
        }


        private void CheckEditIsCleint_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEditIsCleint.Checked)
            {
                TabControl.TabPages.Add(TabCleintInformation);
                TabControl.TabPages.Add(TabCleintOptions);
            }
            else
            {
                TabControl.TabPages.Remove(TabCleintInformation);
                TabControl.TabPages.Remove(TabCleintOptions);
            }
        }

        private void ComboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxAccountType.SelectedItem.ToString() == "ختامي")
            {
                TabControl.TabPages.Remove(TabCleintInformation);
                TabControl.TabPages.Remove(TabCleintOptions);
                TabControl.TabPages.Remove(TabBasicInformation);
                TabControl.TabPages.Remove(TabMix);
                TabControl.TabPages.Remove(TabDist);
                TabControl.TabPages.Insert(0 ,TabFinal);
                TabControl.SelectedIndex = 0;
                CheckEditIsCleint.Hide();
            }
            if (ComboBoxAccountType.SelectedItem.ToString() == "تجميعي")
            {
                TabControl.TabPages.Remove(TabCleintInformation);
                TabControl.TabPages.Remove(TabCleintOptions);
                TabControl.TabPages.Remove(TabBasicInformation);
                TabControl.TabPages.Remove(TabFinal);
                TabControl.TabPages.Remove(TabDist);
                TabControl.TabPages.Insert(0, TabMix);
                TabControl.SelectedIndex = 0;
                CheckEditIsCleint.Hide();
            }
            if (ComboBoxAccountType.SelectedItem.ToString() == "توزيعي")
            {
                TabControl.TabPages.Remove(TabCleintInformation);
                TabControl.TabPages.Remove(TabCleintOptions);
                TabControl.TabPages.Remove(TabBasicInformation);
                TabControl.TabPages.Remove(TabMix);
                TabControl.TabPages.Remove(TabFinal);
                TabControl.TabPages.Insert(0, TabDist);
                TabControl.SelectedIndex = 0;
                CheckEditIsCleint.Hide();
            }
            if (ComboBoxAccountType.SelectedItem.ToString() == "عادي")
            {
                TabControl.TabPages.Remove(TabCleintInformation);
                TabControl.TabPages.Remove(TabCleintOptions);

                TabControl.TabPages.Remove(TabFinal);
                TabControl.TabPages.Remove(TabMix);
                TabControl.TabPages.Remove(TabDist);
                TabControl.TabPages.Insert(0, TabBasicInformation);
                TabControl.SelectedIndex = 0;
                CheckEditIsCleint.Checked = false;
                CheckEditIsCleint.Show();
            }
        }
    }
}
