using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;

namespace PageObjects
{
    public class BasePageObject
    {
        protected readonly AutomationElement container;

        public BasePageObject(AutomationElement container)
        {
            this.container = container;
        }

        protected AutomationElement FindElementByAutomationId(string id)
        {
            var element = this.container.FindFirstDescendant(cf => cf.ByAutomationId(id));
            return element;
        }

        protected AutomationElement FindElementByName(string name)
        {
            var element = this.container.FindFirstDescendant(cf => cf.ByName(name));
            return element;
        }
    }
}