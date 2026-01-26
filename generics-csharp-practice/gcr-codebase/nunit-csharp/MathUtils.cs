using System;
using NUnit.Framework;
public class MathUtils{
    public int Divide(int a, int b){
        if(b == 0){
            throw new ArithmeticException("Cannot divide by zero");
        }
        return a / b;
    }
}
[TestFixture]
public class MathUtilsTests{
    MathUtils utils;
    // Runs before each test case
    [SetUp]
    public void Setup(){
        utils = new MathUtils();
    }
    [Test]
    public void Divide_ByZero_ThrowsArithmeticException(){
        Assert.Throws<ArithmeticException>(() => utils.Divide(10, 0));
    }
    [Test]
    public void Divide_ValidNumbers_ReturnsResult(){
        Assert.AreEqual(5, utils.Divide(10, 2));
    }
}
