using System;
[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute{
    public int Length { get; }
    public MaxLengthAttribute(int length){
        Length = length;
    }
}
