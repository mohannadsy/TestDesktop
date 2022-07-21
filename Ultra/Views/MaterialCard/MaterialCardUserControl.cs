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

namespace Ultra.Views.MaterialCard
{
    public partial class MaterialCardUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public MaterialCardUserControl()
        {
            InitializeComponent();
        }

        private void ButtonFirstUnitBarcode_Click(object sender, EventArgs e)
        {
            new BarcodeForm().Show();
        }

        private void ButtonSecondUnitBarcode_Click(object sender, EventArgs e)
        {
            new BarcodeForm().Show();
        }

        private void ButtonThirdUnitBarcode_Click(object sender, EventArgs e)
        {
            new BarcodeForm().Show();
        }

        private void ButtonFourthUnitBarcode_Click(object sender, EventArgs e)
        {
            new BarcodeForm().Show();
        }

        private void ButtonFifthUnitBarcode_Click(object sender, EventArgs e)
        {
            new BarcodeForm().Show();
        }

        private void ButtonMaterialBounds_Click(object sender, EventArgs e)
        {
            new MaterialBoundsForm().Show();
        }

        private void toggleSwitchInheritMaterial_Toggled(object sender, EventArgs e)
        {
            new InheritedMatrialForm().Show();
        }
    }
}
