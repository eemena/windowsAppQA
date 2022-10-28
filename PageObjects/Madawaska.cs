using FlaUI.Core.AutomationElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PageObjects
{
    public class Madawaska : BasePageObject
    {
        public Madawaska(AutomationElement container)
          : base(container)
        { }

        public TextBox TxtBoxTextSearch => FindElementByAutomationId("txtSearch").AsTextBox();

        public Button BtnSearch => FindElementByAutomationId("btnSearch").AsButton();
        public TextBox TxtBoxInventoryID => FindElementByAutomationId("txtInventoryId").AsTextBox();
        public AutomationElement TxtInventoryID => FindElementByAutomationId("txtInventoryID");
        public Button BtnClose => FindElementByName("Close").AsButton();
    }
}