Feature: Mapping
Demonstration of Specflow's Mapping Feature

    Scenario: ManualTypeMapping
        Given the following conferences1
          | Name    | Location | From       | To         |
          | DevDays | Arnhem   | 2023-05-12 | 2023-05-13 |

    Scenario: SpecflowTypeMapping
        Given the following conferences2
          | Name    | Location | From       | To         |
          | DevDays | Arnhem   | 2023-05-12 | 2023-05-13 |

    Scenario: SpecflowTableMapping
        Given the following conferences3
          | Name    | Location | From       | To         |
          | DevDays | Arnhem   | 2023-05-12 | 2023-05-13 |

    Scenario: SpecflowSingleInstance
        Given the following conference1
          | Name    | Location | From       | To         |
          | DevDays | Arnhem   | 2023-05-12 | 2023-05-13 |

    Scenario: SpecflowSingleInstancePivot
        Given the following conference1
          | Key      | Value   |
          | Name     | DevDays |
          | Location | Arnhem  |

    Scenario: NullValueHandling1
        Given the following conference1
          | Name    | Location | From       | To         |
          | DevDays |          | 2023-05-12 | 2023-05-13 |

    Scenario: NullValueHandling2
        Given the following conference1
          | Name    | Location | From       | To         |
          | DevDays | <null>   | 2023-05-12 | 2023-05-13 |
          
    Scenario: NullValueHandling3
        Given the following conference1
          | Name    | From       | To         |
          | DevDays | 2023-05-12 | 2023-05-13 |
          
    Scenario: ArgumentTransformation
        Given the following conferences
          | Name    | Location | From       | To         |
          | DevDays | Arnhem   | 2023-05-12 | 2023-05-13 |