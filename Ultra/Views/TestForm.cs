using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultra.Views.Account;
using Ultra.Views.Bond;
using Ultra.Views.BranchAndUser;
using Ultra.Views.CostCenter2;
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
            //new CostCenter2Form().Show();
            //new StoreForm().Show();
            //new CurrencyForm().Show();
            //new BondForm().Show();
            new CostCenterForm().Show();
            //new CostCenterStandardForm().Show();

        }
    }
}
