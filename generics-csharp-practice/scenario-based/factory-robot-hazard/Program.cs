using System;
class Program{
    static void Main(string[] args){
        try{
           RobotHazardAuditor auditor=new RobotHazardAuditor();
             // Read arm precision input
                Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
                double armPrecision = Convert.ToDouble(Console.ReadLine());

                // Read worker density input
                Console.WriteLine("Enter Worker Density (1 - 20):");
                int workerDensity = Convert.ToInt32(Console.ReadLine());

                // Read machinery state input
                Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
                string machineryState = Console.ReadLine();

                double risk=auditor.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
                Console.WriteLine("Robot Hazard Risk Score"+risk);
        }
        catch(RobotSafetyException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine("Unexpected Error:"+ex.Message);
        }
    }
}