[Binding]
public class Binding
{
    ScenarioContext _scenarioContext;

    public Binding(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario("web")]
    public static void BeforeWebScenario()
    {
        if(_scenarioContext.ScenarioInfo.Tags.Contains("automated"))
            StartSelenium();
    }
}