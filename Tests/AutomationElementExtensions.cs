using FlaUI.Core.AutomationElements;
using FlaUI.Core.Capturing;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Tests.MainWindowTests;

namespace Tests
{
    public static class AutomationElementExtensions
    {
        public static string SaveScreenshot(this AutomationElement element)
        {
            var img = Capture.Element(element);
            var timestamp = DateTime.UtcNow;
            var format = "yyyyMMdd_HH-mm-ss-fff";
            var timestampStr = timestamp.ToString(format);
            var folderName = Common.Configuration["ScreenshotsPath"];
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            var filePath = $"{folderName}/{timestampStr}_screenshot.png";
            img.ToFile(filePath);
            return filePath;
        }
    }
}