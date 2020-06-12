using TechTalk.SpecFlow;
using spec.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace spec.StepDefinitions
{

    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Estoy en google")]
        public void GivenEstoyEnGoogle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com.mx");
        }
    }
}
