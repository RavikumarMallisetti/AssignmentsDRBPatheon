using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataSampleProject.PageObjects
{
    public class ConfirmDeletionViaJQueryConfirmBoxAttribute : TriggerAttribute
    {
        public ConfirmDeletionViaJQueryConfirmBoxAttribute(TriggerEvents on = TriggerEvents.AfterClick, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context) =>
            Go.To<DeletionJQueryConfirmBox<TOwner>>(temporarily: true)
                .Delete();
    }
}
