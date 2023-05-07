// Copyright (c) Kaylumah, 2023. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Globalization;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

namespace Test.Specflow;

[Binding]
public class GlobalHooks
{
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        DateTimeValueRetriever.DateTimeStyles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
        Service
            .Instance
            .ValueRetrievers
            .Register(new NullValueRetriever(Constants.NullIndicator));
    }
}
