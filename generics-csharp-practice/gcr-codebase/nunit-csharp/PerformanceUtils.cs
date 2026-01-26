using System.Threading;
using NUnit.Framework;
public class PerformanceUtils{
    public int LongRunningTask(){
        Thread.Sleep(3000);
        return 1;
    }
}
[TestFixture]
public class PerformanceUtilsTests{
    PerformanceUtils utils;
    [SetUp]
    public void Setup(){
        utils = new PerformanceUtils();
    }
    [Test]
    [Timeout(2000)]
    public void LongRunningTask_TimeoutTest(){
        utils.LongRunningTask();
    }
}
