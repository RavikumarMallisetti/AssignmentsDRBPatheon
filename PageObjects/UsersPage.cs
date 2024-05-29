using AtataDemo.UITests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataSampleProject.PageObjects
{
    using _ = UsersPage;

    [VerifyH1]
    public class UsersPage : Page<_>
    {
        public void NavigateToSomeOtherPage(string pageName)
        {
            if (pageName.Equals("Products"))
            {


            }
        }

        public Button<UserEditWindow, _> New { get; private set; }

        public Link<ProductsPage, _> ProductsButton { get; private set; }

        public Table<UserTableRow, _> Users { get; private set; }

        public class UserTableRow : TableRow<_>
        {
            public Text<_> FirstName { get; private set; }

            public Text<_> LastName { get; private set; }

            public Text<_> Email { get; private set; }

            [CloseConfirmBox]
            public Button<_> Delete { get; private set; }
        }
    }
}
