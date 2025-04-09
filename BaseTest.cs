using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationPracticeFormTests
{
    public class BaseTest
    {
        protected IWebDriver? driver;

        public void Initialize()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            
            // We can re-enable headless mode for production
            chromeOptions.AddArgument("--headless");
            
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            
            // Set reasonable timeouts
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }

        public void Cleanup()
        {
            driver?.Quit();
        }
    }
}