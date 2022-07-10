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
    public partial class AccountForm : DevExpress.XtraEditors.XtraForm
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void ChartBranchesAndUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new AccountCardUserControl());
        }
    }
}