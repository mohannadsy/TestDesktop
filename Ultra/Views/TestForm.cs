using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultra.Views.Account;
using Ultra.Views.Bond;
using Ultra.Views.BranchAndUser;
using Ultra.Views.CostCenter;
using Ultra.Views.Currency;
using Ultra.Views.Store;
using Ultra.Views.CostCenterStandard;

namespace Ultra.Views
{
    class TestForm
    {
        public static void execute()
        {
            //new BranchAndUserForm().Show();
            //new AccountForm().Show();
            //new CostCenterForm().Show();
            //new StoreForm().Show();
            //new CurrencyForm().Show();
            //new BondForm().Show();

            new CostCenterStandardForm().Show();

        }
    }
}
