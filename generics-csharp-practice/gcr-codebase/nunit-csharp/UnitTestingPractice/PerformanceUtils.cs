using System.Threading;
namespace UnitTestingPractice{
    public class PerformanceUtils{
        public int LongRunningTask(){
            Thread.Sleep(3000); // 3 seconds
            return 1;
        }
    }
}
