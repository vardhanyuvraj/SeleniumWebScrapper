using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConfluenceCountSolution
{
    class TestCaseCalculation
    {

        private IWebDriver webDriver;

        private int totalAutomated;
        private int totalReviewed;
        private int totalCases;

        public TestCaseCalculation(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void testCaseCalculation()
        {
            int totalValue1 = 0;
            int totalValue2 = 0;
            int totalValue3 = 0;
            IList<IWebElement> elementsToCount = new PageObjects(webDriver).getElementsToCount();
            for (int i = 0; i < elementsToCount.Count; i++)
            {
                string text = elementsToCount[i].Text;
                var matches = Regex.Matches(text, @"\((\d+)/(\d+)/(\d+)\)");
                foreach (Match match in matches)
                {
                    if (match.Groups.Count == 4)
                    {
                        int value1 = int.Parse(match.Groups[1].Value);
                        int value2 = int.Parse(match.Groups[2].Value);
                        int value3 = int.Parse(match.Groups[3].Value);
                        totalValue1 += value1;
                        totalValue2 += value2;
                        totalValue3 += value3;
                    }
                }
            }
            Console.WriteLine("|" + string.Format(" {0,-23} | {1,-17} | {2,-16} | {3,-13} ",
                                 new PageObjects(webDriver).getSuiteTitle().Text, totalValue1, totalValue2, totalValue3) + "|");
            totalAutomated += totalValue1;
            totalReviewed += totalValue2;
            totalCases += totalValue3;
            webDriver.Navigate().Back();
        }

        public int getTotalAutomated()
        {
            return totalAutomated;
        }
        public int getTotalReviewed()
        {
            return totalReviewed;
        }
        public int getTotalCasesCount()
        {
            return totalCases;
        }
    }
}
