namespace AtataDemo.UITests;

using AtataSampleProject.PageObjects;
using Atata;
using _ = ProductsPage;

[VerifyTitle("Products - Atata Sample App")]
[Url("products")]
public class ProductsPage : Page<_>
{
    public H1<_> Header { get; private set; }


    public Table<ProductTableRow, _> ProductsTable { get; private set; }

    [ControlDefinition("tr[td]", ComponentTypeName = "row")]
    public class ProductTableRow : TableRow<_>
    {
        [FindByColumnHeader("Name")]
        public Text<_> Name { get; private set; }

        [FindByColumnHeader("Amount")]
        public Number<_> Amount { get; private set; }

        [FindByColumnHeader("Price")]
        public Currency<_> Price { get; private set; }

        [CloseConfirmBox]
        public ButtonDelegate<_> DeleteUsingJSConfirm { get; private set; }

        [FindByContent("Delete Using BS Modal")]
        public ButtonDelegate<DeletionConfirmationBSModal<_>, _> DeleteUsingBSModal { get; private set; }

        [FindByContent("Delete Using BS Modal")]
        [ConfirmDeletionViaBSModal]
        public ButtonDelegate<_> DeleteUsingBSModalViaTrigger { get; private set; }

        [FindByContent("Delete Using jquery-confirm")]
        public ButtonDelegate<DeletionJQueryConfirmBox<_>, _> DeleteUsingJQueryConfirm { get; private set; }

        [FindByContent("Delete Using jquery-confirm")]
        [ConfirmDeletionViaJQueryConfirmBox]
        public ButtonDelegate<_> DeleteUsingJQueryConfirmViaTrigger { get; private set; }

    }
}