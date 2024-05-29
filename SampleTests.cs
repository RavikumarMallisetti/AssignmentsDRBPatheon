using AtataDemo.UITests;
using System.Linq;

namespace AtataSampleProject
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void TestA()
        {

            //Go.To<OrdinaryPage>()
            //    .PageTitle.Should.Contain("Atata");

            LoginAndNavigateToProductsPage().ProductsButton.ClickAndGo<ProductsPage>()
              .PageTitle.Should.Contain("Products - Atata Sample App");
            var xx=AtataContext.Current.Driver.FindElements(By.XPath("//table/descendant::tr/td"));
            var numberOfRows = xx.Count() / 4;
            for (var i = 0; i < numberOfRows; i++)
            {
                var name = xx[i].Text;
                var price = xx[i+1].Text;
                var amount = xx[i + 2].Text;

                i=i+4;
            }

            //LoginAndNavigateToProductsPage().ProductsButton.ClickAndGo<ProductsPage>()
            //  .PageTitle.Should.Contain("Products - Atata Sample App")
            //   .ProductsTable.Rows.Count.Get(out int count)
            //   .ProductsTable.Rows[x => x.Name == "Armchair"].DeleteUsingJQueryConfirmViaTrigger()
            //   .ProductsTable.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
            //   .ProductsTable.Rows.Should.HaveCount(count - 1)
            //   .ProductsTable.Rows.ForEach(x=>x.Amount).v
            //   .ProductsTable.Rows.Select(x => x.Price.Value).Value.Sum().Equals("945");

        }

        [Test]
        public void TestB()
        {
            LoginAndNavigateToProductsPage().ProductsButton.ClickAndGo<ProductsPage>()
           .ProductsTable.Rows.Count.Get(out int count)
           .ProductsTable.Rows[x => x.Name == "Armchair"].DeleteUsingJQueryConfirmViaTrigger()
           .AggregateAssert(x =>
           {
               x.ProductsTable.Rows[x => x.Name == "Armchair"].Should.Not.BePresent();
               x.ProductsTable.Rows.Count.Should.Equal(count - 1);
               x.ProductsTable.Rows.ToList().Sum(x => x.Amount.Value).Equals(845);
           });
        }
    }
}
