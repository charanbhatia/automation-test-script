using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationPracticeFormTests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        public void Initialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void Cleanup()
        {
            driver.Quit();
        }
    }
}