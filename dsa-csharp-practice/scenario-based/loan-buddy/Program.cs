using System;
class Program{
    static void Main(){
        Applicant user = new Applicant("Lavanya", 720, 40000, 500000);
        // Polymorphism 
        LoanApplication loan = new HomeLoan(240, 8.5);
        // Process loan approval
        if (loan.ApproveLoan(user)){
            Console.WriteLine("Loan Approved for " + user.Name);
            Console.WriteLine("Monthly EMI: " + loan.CalculateEMI(user));
        }
        else{
            Console.WriteLine("Loan Rejected for " + user.Name);
        }
        Console.WriteLine("Final Status: " + loan.GetStatus());
    }
}
