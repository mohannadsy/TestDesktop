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


        private void buttonNew_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new CostCenterCardUserControl());
        }

        private void treeListCostCenters_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new CostCenterCardUserControl());
        }
    }
}