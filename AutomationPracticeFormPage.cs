using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationPracticeFormTests
{
    public class AutomationPracticeFormPage
    {
        private readonly IWebDriver driver;

        public AutomationPracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Using multiple locator strategies for robustness
        private By FirstNameField => By.CssSelector("input[placeholder='Name']");
        private By LastNameField => By.CssSelector("input[placeholder='Surname']");
        private By EmailField => By.CssSelector("input[placeholder='Email']");

        public void NavigateTo()
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        }

        public void EnterFirstName(string firstName)
        {
            WaitForElement(FirstNameField).Clear();
            WaitForElement(FirstNameField).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            WaitForElement(LastNameField).Clear();
            WaitForElement(LastNameField).SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            WaitForElement(EmailField).Clear();
            WaitForElement(EmailField).SendKeys(email);
        }

        public string? GetFirstName()
        {
            return WaitForElement(FirstNameField).GetAttribute("value");
        }

        public string? GetLastName()
        {
            return WaitForElement(LastNameField).GetAttribute("value");
        }

        public string? GetEmail()
        {
            return WaitForElement(EmailField).GetAttribute("value");
        }

        private IWebElement WaitForElement(By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementExists(locator));
        }
    }
}