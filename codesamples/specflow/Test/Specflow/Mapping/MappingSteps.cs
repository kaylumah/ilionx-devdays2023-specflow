// Copyright (c) Kaylumah, 2023. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Globalization;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Infrastructure;
using Test.Specflow.Entities;

namespace Test.Specflow.Mapping;

[Binding]
[Scope(Feature = "Mapping")]
public class MappingSteps
{
    private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

    public MappingSteps(ISpecFlowOutputHelper specFlowOutputHelper)
    {
        _specFlowOutputHelper = specFlowOutputHelper;
    }
    
    [Given]
    public void GivenTheFollowingConferences1(Table table)
    {
        foreach (var tableRow in table.Rows)
        {
            string name = tableRow["Name"];
            string location = tableRow["Location"];
            string from = tableRow["From"];
            string to = tableRow["To"];
            
            // ...
            var conference = new Conference()
            {
                Name = name,
                Location = location,
                From = string.IsNullOrEmpty(from) ? null : DateTimeOffset.ParseExact(from, "yyyy-MM-dd", CultureInfo.InvariantCulture,  DateTimeStyles.AssumeUniversal),
                To = string.IsNullOrEmpty(to) ? null : DateTimeOffset.ParseExact(to, "yyyy-MM-dd", CultureInfo.InvariantCulture,  DateTimeStyles.AssumeUniversal)
            };
            _specFlowOutputHelper.WriteLine(conference.ToJson());
        }
    }
    
    [Given]
    public void GivenTheFollowingConferences2(Table table)
    {
        foreach (var tableRow in table.Rows)
        {
            string name = tableRow.GetString("Name");
            string location = tableRow.GetString("Location");
            DateTimeOffset from = tableRow.GetDateTime("From");
            DateTimeOffset to = tableRow.GetDateTime("To");
            
            // ...
            var conference = new Conference()
            {
                Name = name,
                Location = location,
                From = from,
                To = to
            };
            _specFlowOutputHelper.WriteLine(conference.ToJson());
        }
    }

    [Given]
    public void GivenTheFollowingConferences3(Table table)
    {
        var conferences = table.CreateSet<Conference>();
        
        // ...
        _specFlowOutputHelper.WriteLine(conferences.ToJson());
    }
    
    [Given]
    public void GivenTheFollowingConference1(Table table)
    {
        var conference = table.CreateInstance<Conference>();
        
        // ...
        _specFlowOutputHelper.WriteLine(conference.ToJson());
    }
    
    [Given]
    public void GivenTheFollowingConferences(List<Conference> conferences)
    {
        _specFlowOutputHelper.WriteLine(conferences.ToJson());
    }

    [StepArgumentTransformation]
    public static List<Conference> ToConferences(Table table)
    {
        return table.CreateSet<Conference>().ToList();
    }
}
