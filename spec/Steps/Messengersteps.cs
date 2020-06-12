using TechTalk.SpecFlow;
using spec.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace spec.StepDefinitions
{

    [Binding]
    public class MessengerSteps
    {
        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver;

        public MessengerSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = new ChromeDriver();

        }

        [Given(@"i go to app")]
        public void GivenIGoToApp()
        {
            driver.Navigate().GoToUrl("https://localhost:5001/message");
        }

        [When(@"i enter my name '(.*)'")]
        public void WhenIEnterMyName(string name)
        {
            driver.FindElement(By.Id("name")).SendKeys(name);
        }

        [When(@"i click the button")]
        public void WhenIClickTheButton()
        {
            driver.FindElement(By.Id("btnGetMessage")).Click();
        }

        [Then(@"should see '(.*)'")]
        public void ThenIEnterMyName(string result)
        {
            string value = driver.FindElement(By.Id("salute")).Text;
            Assert.Equal(result, value);
            driver.Close();
            //driver.Quit();
        }




    }
}
