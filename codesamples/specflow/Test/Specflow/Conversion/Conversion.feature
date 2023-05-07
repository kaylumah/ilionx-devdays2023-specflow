Feature: Conversion

@V1
Scenario: Order Example 1
	Given we have '3' items in stock:
	
@V2
Scenario: Order Example 2
    Given we have '0' items in stock:
    Given we have 'no' items in stock:
    Given we have '5' items in stock:
    
Scenario Outline: Technical Id
    Given we have the following technical id '<Id>':
    
    Scenarios: 
        | Id                                   |
        | 7e53b915-a454-4337-afae-0cf0e69814a2 |
        | 7e53b915-a454-4337-afae              |
        | 7e53b915-a454-4337                   |
        | 7e53b915-a454                        |
        | 7e53b915                             |
        | 7                                    |
        
Scenario: Other Item
    Given we have the following item:
        | ID | Int |
        | a  | no  |