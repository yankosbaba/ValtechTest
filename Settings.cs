using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMReply
{
    public static class Settings
    {
        public static string VmUrl;
        public static string IeDriverPath;
        public static string ChromeDriverPath;
        public static string FireFoxDriverPath;
        public static string BrowserType;
        public static int ImplicitTimeoutSeconds;


        public static void Setting()
        {
            var appSettings = ConfigurationManager.AppSettings;

            // Webdriver
            IeDriverPath = appSettings["ie.driver.path"];
            ChromeDriverPath = appSettings["chrome.driver.path"];
            BrowserType = appSettings["browser.type"];
            ImplicitTimeoutSeconds = Convert.ToInt16(appSettings["implicit.timeout.seconds"]);

            // Environment specific
            VmUrl = appSettings["vm.url"];
        }


    }

}
