// Copyright (c) Kaylumah, 2023. All rights reserved.
// See LICENSE file in the project root for full license information.

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Infrastructure;

namespace Test.Specflow.Conversion;
[Binding]
public class ConversionSteps
{
    private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

    public ConversionSteps(ISpecFlowOutputHelper specFlowOutputHelper)
    {
        _specFlowOutputHelper = specFlowOutputHelper;
    }

    [Scope(Tag = "V1")]
    [Given(@"we have '(.*)' items in stock:")]
    public void GivenWeHaveASpecifiedNumberOfItemsInStock(int itemsInStock)
    {
        _specFlowOutputHelper.WriteLine($"items: '{itemsInStock}'");
    }

    [Scope(Tag = "V2")]
    [Given(@"we have '(.*)' items in stock:")]
    public void GivenWeHaveASpecifiedNumberOfItemsInStock(HumanReadableIntExpression itemsInStock)
    {
        _specFlowOutputHelper.WriteLine($"items: '{itemsInStock.Value}'");
    }

    [Given(@"we have the following technical id '(.*)':")]
    public void GivenTheFollowingTechnicalId(Guid id)
    {
        _specFlowOutputHelper.WriteLine($"id: '{id}'");
    }
    
    [StepArgumentTransformation]
    public static HumanReadableIntExpression TransformItems(string expression)
    {
        #pragma warning disable
        return !"no".Equals(expression, StringComparison.Ordinal) ? new HumanReadableIntExpression(int.Parse(expression)) : new HumanReadableIntExpression(0);
    }
    
    [Given(@"we have the following item:")]
    public void GivenTheFollowingItem(Table table)
    {
        var item = table.CreateInstance<OtherEntity>();
    }
}
