using OpenQA.Selenium;
using System.Collections.Generic;

namespace ConfluenceCountSolution
{
    class PageObjects
    {
        private IWebDriver webDriver;

        public PageObjects(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        private IWebElement userName => webDriver.FindElement(By.Id("os_username"));
        private IWebElement password => webDriver.FindElement(By.Id("os_password"));
        private IWebElement loginButton => webDriver.FindElement(By.Id("loginButton"));
        private IWebElement allSuiteName => webDriver.FindElement(By.XPath("//span[@class='label' and text()='13 more child pages']"));
        private IWebElement suiteTitle => webDriver.FindElement(By.XPath("//h1[@id='title-text']"));
        private IList<IWebElement> elementsToCount => webDriver.FindElements(By.XPath("//div[@id='main-content'] //li"));
        private IWebElement appointmentServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'AppointmentService')]"));
        private IWebElement auditServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'Audit Service')]"));
        private IWebElement ccdaTab => webDriver.FindElement(By.XPath("//a[@href='/pages/viewpage.action?pageId=403574043']"));
        private IWebElement clinicalServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'ClinicalService')]"));
        private IWebElement documentServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'DocumentService')]"));
        private IWebElement globalServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'Global Service')]"));
        private IWebElement integratedTestsTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'Integrated Tests')]"));
        private IWebElement interfaceServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'InterfaceService')]"));
        private IWebElement notificationServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'NotificationService')]"));
        private IWebElement orderServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'Order Service')]"));
        private IWebElement patientServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'PatientService')]"));
        private IWebElement practiceServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'PracticeService')]"));
        private IWebElement regimenServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'Regimen Service')]"));
        private IWebElement workQueueServiceTab => webDriver.FindElement(By.XPath("//a[contains(text(), 'WorkQueue Service')]"));





        public IWebElement getUserName()
        {
            return userName;
        }

        public IWebElement getPassword()
        {
            return password;
        }

        public IWebElement getLoginButton()
        {
            return loginButton;
        }

        public IWebElement getAllSuiteName()
        {
            return allSuiteName;
        }

        public IWebElement getSuiteTitle()
        {
            return suiteTitle;
        }

        public IList<IWebElement> getElementsToCount()
        {
            return elementsToCount;
        }

        public IWebElement getAppointmentServiceTab()
        {
            return appointmentServiceTab;
        }

        public IWebElement getAuditServiceTab()
        {
            return auditServiceTab;
        }

        public IWebElement getCcdaTab()
        {
            return ccdaTab;
        }

        public IWebElement getClinicalServiceTab()
        {
            return clinicalServiceTab;
        }

        public IWebElement getDocumentServiceTab()
        {
            return documentServiceTab;
        }
        public IWebElement getGlobalServiceTab()
        {
            return globalServiceTab;
        }
        public IWebElement getIntegratedTestsTab()
        {
            return integratedTestsTab;
        }
        public IWebElement getInterfaceServiceTab()
        {
            return interfaceServiceTab;
        }
        public IWebElement getNotificationServiceTab()
        {
            return notificationServiceTab;
        }
        public IWebElement getOrderServiceTab()
        {
            return orderServiceTab;
        }
        public IWebElement getPatientServiceTab()
        {
            return patientServiceTab;
        }
        public IWebElement getPracticeServiceTab()
        {
            return practiceServiceTab;
        }
        public IWebElement getRegimenServiceTab()
        {
            return regimenServiceTab;
        }
        public IWebElement getWorkQueueServiceTab()
        {
            return workQueueServiceTab;
        }
    }
}
