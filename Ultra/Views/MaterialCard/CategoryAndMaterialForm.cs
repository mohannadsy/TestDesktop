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
    public partial class CategoryAndMaterialForm : DevExpress.XtraEditors.XtraForm
    {
        public CategoryAndMaterialForm()
        {
            InitializeComponent();
        }

        private void ChartCategoriesAndMaterials_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ChartCategoriesAndMaterials.SelectedNode.Name == "NodeMaterial")
            {
                PanelMain.Controls.Clear();
                PanelMain.Controls.Add(new MaterialCardUserControl());
            }
        }
    }
}