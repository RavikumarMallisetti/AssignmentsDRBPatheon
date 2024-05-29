using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using Atata.Bootstrap;

namespace AtataSampleProject.PageObjects
{
    using _ = UserEditWindow;

    public class UserEditWindow : BSModal<_>
    {
        [FindById]
        public GeneralTabPane General { get; private set; }

        [FindById]
        public AdditionalTabPane Additional { get; private set; }

        [Term("Save", "Create")]
        public Button<UsersPage, _> Save { get; private set; }

        public class GeneralTabPane : BSTabPane<_>
        {
            public TextInput<_> FirstName { get; private set; }

            public TextInput<_> LastName { get; private set; }

            [RandomizeStringSettings("{0}@mail.com")]
            public TextInput<_> Email { get; private set; }
        }

        public class AdditionalTabPane : BSTabPane<_>
        {
            public DateInput<_> Birthday { get; private set; }

            public TextArea<_> Notes { get; private set; }
        }
    }
}
