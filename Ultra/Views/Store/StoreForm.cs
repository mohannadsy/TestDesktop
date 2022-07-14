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

namespace Ultra.Views.Store
{
    public partial class StoreForm : DevExpress.XtraEditors.XtraForm
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void ChartAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new StoreCardUserControl());
        }
    }
}