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

namespace Ultra.Views.CostCenterDev
{
    public partial class CostCenterDev : DevExpress.XtraEditors.XtraForm
    {
        public CostCenterDev()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            panelControlMain.Controls.Clear();
            panelControlMain.Controls.Add(new CostCenterDevUserControl());
        }
    }
}