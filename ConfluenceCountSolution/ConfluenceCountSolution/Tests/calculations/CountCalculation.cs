using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using ClosedXML.Excel;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ConfluenceCountSolution
{
    public class CountCalculation
    {

        private IWebDriver webDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //options.AddArgument("--disable-gpu");
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void ReImagineEHRCasesCount()
        {
            string excelFilePath = @"C:\Users\yuvraj.vardhan\OneDrive - Integra Connect LLC\Desktop\login.xlsx";
            var workbook = new XLWorkbook(excelFilePath);
            IXLWorksheet worksheet = workbook.Worksheet(1);
            webDriver.Navigate().GoToUrl(worksheet.Cell("C2").GetString());
            PageObjects pageObjects = new PageObjects(webDriver);
            TestCaseCalculation testCaseCalculation = new TestCaseCalculation(webDriver);
            pageObjects.getUserName().SendKeys(worksheet.Cell("A2").GetString());
            pageObjects.getPassword().SendKeys(worksheet.Cell("B2").GetString());
            pageObjects.getLoginButton().Click();
            pageObjects.getAllSuiteName().Click();
            string horizontalLine = new string('-', 80);
            string verticalLine = "|";
            Console.WriteLine("+" + horizontalLine + "+"); // Top border of the box
            Console.WriteLine(verticalLine + " Suite                   | Automated         | Reviewed         | Total Cases   " + verticalLine); // Header
            Console.WriteLine("+" + horizontalLine + "+"); // Separator line
            pageObjects.getAppointmentServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getAuditServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getCcdaTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getClinicalServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getDocumentServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getGlobalServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getIntegratedTestsTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getInterfaceServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getNotificationServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getOrderServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getPatientServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getPracticeServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getRegimenServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            pageObjects.getWorkQueueServiceTab().Click();
            testCaseCalculation.testCaseCalculation();
            Console.WriteLine("+" + horizontalLine + "+"); // Bottom border of the box
            Console.WriteLine("|" + string.Format(" {0,-23} | {1,-17} | {2,-16} | {3,-13} ",
                                 "Final Count", testCaseCalculation.getTotalAutomated() , testCaseCalculation.getTotalReviewed(), testCaseCalculation.getTotalCasesCount()) + "|");
            Console.WriteLine("+" + horizontalLine + "+"); // Bottom border of the box
        }

        [TearDown]
        public void closeBrowser()
        {
            webDriver.Quit();
        }
    }
}

       