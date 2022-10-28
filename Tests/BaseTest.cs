using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.TestUtilities;
using FlaUI.UIA3;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class BaseTest : FlaUITestBase
    {
        private readonly Application app;

        public BaseTest()
        {
            this.app = Application.Launch(Common.Configuration["MadawaskaPath"]);
            app.WaitWhileMainHandleIsMissing();
        }

        protected override AutomationBase GetAutomation() => new UIA3Automation();

        protected override Application StartApplication() => this.app;

        protected Window Window => base.Application.GetMainWindow(base.Automation);
    }
}