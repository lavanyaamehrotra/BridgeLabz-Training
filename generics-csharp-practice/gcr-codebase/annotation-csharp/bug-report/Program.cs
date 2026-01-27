using System.Reflection;
class Program{
    static void Main(){
        var bugs =typeof(CodeBase).GetMethod("ProcessData").GetCustomAttributes<BugReportAttribute>();
        foreach (var bug in bugs){
            Console.WriteLine(bug.Description);
        }
    }
}
