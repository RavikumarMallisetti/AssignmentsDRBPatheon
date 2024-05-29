using AtataDemo.UITests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataSampleProject.PageObjects
{
    using _ = SignInPage;
    [Url("signin")]
    [VerifyH1]
    public class SignInPage : Page<_>
    {
        public TextInput<_> Email { get; private set; }

        public PasswordInput<_> Password { get; private set; }

        public Button<UsersPage, _> SignIn { get; private set; }
    }
}
