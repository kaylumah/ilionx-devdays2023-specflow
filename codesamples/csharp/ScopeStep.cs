[When(@"I perform a simple search on '(.*)'",
    Scope(Tag = "controller"))]
public void WhenIPerformASimpleSearchOn(string searchTerm)
{
    var controller = new CatalogController();
    actionResult = controller.Search(searchTerm);
}

[When(@"I perform a simple search on '(.*)'"),
    Scope(Tag = "web")]
public void PerformSimpleSearch(string title)
{
    selenium.GoToThePage("Home");
    selenium.Type("searchTerm", title);
    selenium.Click("searchButton");
}