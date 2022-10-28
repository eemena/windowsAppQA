using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using PageObjects;

namespace Tests
{
    [TestFixture]
    public class MainWindowTests : BaseTest
    {
        private Madawaska Madawaska => new(base.Window);

        [Test]
        public void InventoryFieldTest()
        {
            var madawaska = this.Madawaska;

            madawaska.TxtBoxTextSearch.Enter("17002");
            madawaska.BtnSearch.Click();
            Wait.UntilInputIsProcessed();
            Assert.That("17002".Equals(madawaska.TxtInventoryID.AsTextBox().Text));
            madawaska.TxtInventoryID.SaveScreenshot();
            madawaska.BtnClose.Click();
        }
    }
}