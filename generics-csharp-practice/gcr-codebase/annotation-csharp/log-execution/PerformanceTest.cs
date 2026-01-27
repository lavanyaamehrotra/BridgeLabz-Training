using System.Threading;
public class PerformanceTest{
    [LogExecutionTime]
    public void FastMethod(){
        Thread.Sleep(200);
    }
    [LogExecutionTime]
    public void SlowMethod(){
        Thread.Sleep(600);
    }
}
