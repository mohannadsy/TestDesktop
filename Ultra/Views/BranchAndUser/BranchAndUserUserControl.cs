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
using Ultra.Views.BranchAndUser;
namespace Ultra.Views.BranchAndUser
{
    public partial class BranchAndUserUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public BranchAndUserUserControl()
        {
            InitializeComponent();
        }

        private void BranchAndUserUserControl_Load(object sender, EventArgs e)
        {
            PanelSide.Controls.Add(new ChartBranchesAndUsersUserControl());
            
        }
    }
}
