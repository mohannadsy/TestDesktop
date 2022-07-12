using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultra.Views.Account;
using Ultra.Views.BranchAndUser;
using Ultra.Views.CostCenter;

namespace Ultra.Views
{
    class TestForm
    {
        public static void execute()
        {
            new BranchAndUserForm().Show();
            new AccountForm().Show();
            new CostCenterForm().Show();
        }
    }
}
