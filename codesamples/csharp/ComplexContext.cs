[Binding]
public class WebDriverSupport
{
  private readonly IObjectContainer objectContainer;

  public WebDriverSupport(IObjectContainer objectContainer)
  {
    this.objectContainer = objectContainer;
  }

  [BeforeScenario]
  public void InitializeWebDriver()
  {
    var webDriver = new FirefoxDriver();
    objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
  }
}