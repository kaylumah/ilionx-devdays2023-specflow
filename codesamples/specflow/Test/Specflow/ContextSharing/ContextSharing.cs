// Copyright (c) Kaylumah, 2023. All rights reserved.
// See LICENSE file in the project root for full license information.

using FluentAssertions;
using TechTalk.SpecFlow;

namespace Test.Specflow.ContextSharing;

[Binding]
[Scope(Feature = "ContextSharing")]
public sealed class ContextSharing
{
    private readonly CalculatorContext _calculatorContext;

    public ContextSharing(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculatorContext.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculatorContext.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _calculatorContext.Result = _calculatorContext.FirstNumber + _calculatorContext.SecondNumber;
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        _calculatorContext.Result.Should().Be(result);
    }
}
