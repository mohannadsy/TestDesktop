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

namespace Ultra.Views.CostCenter
{
    public partial class CostCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public CostCenterForm()
        {
            InitializeComponent();
        }

        private void ChartAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new CostCenterCardUserControl());
        }
    }
}