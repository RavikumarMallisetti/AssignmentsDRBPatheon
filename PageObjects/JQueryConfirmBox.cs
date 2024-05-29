using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataSampleProject.PageObjects
{
    [PageObjectDefinition("div", ContainingClass = "jconfirm-box", ComponentTypeName = "confirm box")]
    [WindowTitleElementDefinition("span", ContainingClass = "jconfirm-title")]
    public class JQueryConfirmBox<TOwner> : PopupWindow<TOwner>
    where TOwner : JQueryConfirmBox<TOwner>
    {
    }
}
