using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataSampleProject.PageObjects
{
    [Name("Deletion Confirmation")]
    [WindowTitle("Confirmation")]
    public class DeletionJQueryConfirmBox<TNavigateTo> : JQueryConfirmBox<DeletionJQueryConfirmBox<TNavigateTo>>
    where TNavigateTo : PageObject<TNavigateTo>
    {
        [Term(TermCase.MidSentence)]
        public ButtonDelegate<TNavigateTo, DeletionJQueryConfirmBox<TNavigateTo>> Delete { get; private set; }

        [Term(TermCase.MidSentence)]
        public ButtonDelegate<TNavigateTo, DeletionJQueryConfirmBox<TNavigateTo>> Cancel { get; private set; }
    }
}
