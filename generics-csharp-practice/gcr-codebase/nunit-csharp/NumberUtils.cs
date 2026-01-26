using NUnit.Framework;
public class NumberUtils{
    public bool IsEven(int number){
        return number % 2 == 0;
    }
}
[TestFixture]
public class NumberUtilsTests{
    NumberUtils utils;
    [SetUp]
    public void Setup(){
        utils = new NumberUtils();
    }
    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_Test(int number, bool expected){
        Assert.AreEqual(expected, utils.IsEven(number));
    }
}
