// Copyright (c) Kaylumah, 2023. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Test.Specflow.Conversion;

#pragma warning disable
public class HumanReadableIntExpression
{
    public int Value { get; }

    public HumanReadableIntExpression(int value)
    {
        Value = value;
    }
}

public class OtherEntity
{
    public Guid? Id { get; set; }
    
    public HumanReadableIntExpression Int { get; set; }
}
