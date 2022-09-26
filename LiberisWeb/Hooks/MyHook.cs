using LiberisWeb.Drivers;
using TechTalk.SpecFlow;

namespace LiberisWeb.Hooks
{
    [Binding]
    public class MyHooks
    {
        private ScenarioContext _scenarioContext;        

        public MyHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [AfterScenario]
        public void closeDriver()
        {
           Utils.closeDriver();
        }
    }
}
