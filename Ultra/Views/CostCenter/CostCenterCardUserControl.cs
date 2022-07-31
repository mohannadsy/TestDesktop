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
    public partial class CostCenterCardUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public CostCenterCardUserControl()
        {
            InitializeComponent();
        }

        private void comboBoxSecurityDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSecurityDegree.SelectedIndex == 0)
                labelSecurityColor.BackColor = Color.Green;
            if (comboBoxSecurityDegree.SelectedIndex == 1)
                labelSecurityColor.BackColor = Color.Gold;
            if (comboBoxSecurityDegree.SelectedIndex == 2)
                labelSecurityColor.BackColor = Color.Orange;
            if (comboBoxSecurityDegree.SelectedIndex == 3)
                labelSecurityColor.BackColor = Color.Red;
        }
    }
}
