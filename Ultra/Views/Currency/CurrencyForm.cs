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

namespace Ultra.Views.Currency
{
    public partial class CurrencyForm : DevExpress.XtraEditors.XtraForm
    {
        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void ChartAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}