using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.DevTools.V125.Page;
using OpenQA.Selenium;
using BoDi;

namespace CollaboratedHRM.Utilities
{
    public class ExtentReport
    {
        private readonly IObjectContainer _objectContainer;
        public IWebDriver _driver;
        public static ExtentReports extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        

        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = dir.Replace("bin\\Debug\\net8.0", "TestResults");

        public static void ExtentReportInit()
        {
            var htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Application", "Orange");
            extent.AddSystemInfo("Browser", "Edge");
            extent.AddSystemInfo("OS", "Windows");
        }
        public static void ExtentReportTearDown()
        {
           
            extent.Flush();
           

        }

        
    }
}
