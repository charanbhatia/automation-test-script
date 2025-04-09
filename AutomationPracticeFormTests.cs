using NUnit.Framework;

namespace AutomationPracticeFormTests
{
    [TestFixture]
    public class AutomationPracticeFormTests : BaseTest
    {
        private AutomationPracticeFormPage formPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            formPage = new AutomationPracticeFormPage(driver);
            formPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Cleanup();
        }

        [Test]
        public void TestFirstNameField()
        {
            string firstName = "John";
            formPage.EnterFirstName(firstName);
            Assert.AreEqual(firstName, formPage.GetFirstName());
        }

        [Test]
        public void TestLastNameField()
        {
            string lastName = "Doe";
            formPage.EnterLastName(lastName);
            Assert.AreEqual(lastName, formPage.GetLastName());
        }

        [Test]
        public void TestEmailField()
        {
            string email = "john.doe@example.com";
            formPage.EnterEmail(email);
            Assert.AreEqual(email, formPage.GetEmail());
        }
    }
}