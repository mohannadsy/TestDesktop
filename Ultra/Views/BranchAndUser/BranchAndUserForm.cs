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

namespace Ultra.Views.BranchAndUser
{
    public partial class BranchAndUserForm : DevExpress.XtraEditors.XtraForm
    {
        public BranchAndUserForm()
        {
            InitializeComponent();
        }

        private void ChartBranchesAndUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(ChartBranchesAndUsers.SelectedNode.Name == "NodeBranch")
            {
                PanelMain.Controls.Clear();
                PanelMain.Controls.Add(new BranchCardUserControl());
            }
            else
            {
                PanelMain.Controls.Clear();
                PanelMain.Controls.Add(new UserCardUserControl());
            }
        }
    }
}