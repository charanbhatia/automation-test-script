using OpenQA.Selenium;

namespace AutomationPracticeFormTests
{
    public class AutomationPracticeFormPage
    {
        private readonly IWebDriver driver;

        public AutomationPracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators
        private By FirstNameField => By.Id("firstName");
        private By LastNameField => By.Id("lastName");
        private By EmailField => By.Id("userEmail");

        // Methods
        public void NavigateTo()
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(FirstNameField).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(LastNameField).SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(EmailField).SendKeys(email);
        }

        public string GetFirstName()
        {
            return driver.FindElement(FirstNameField).GetAttribute("value");
        }

        public string GetLastName()
        {
            return driver.FindElement(LastNameField).GetAttribute("value");
        }

        public string GetEmail()
        {
            return driver.FindElement(EmailField).GetAttribute("value");
        }
    }
}