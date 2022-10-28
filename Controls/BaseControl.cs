using FlaUI.Core.AutomationElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    public class BaseControl
    {
        protected readonly AutomationElement container;

        public BaseControl(AutomationElement container)
        {
            this.container = container;
        }
    }
}