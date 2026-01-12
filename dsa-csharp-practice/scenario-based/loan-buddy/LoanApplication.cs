using System;
public abstract class LoanApplication : IApprovable{
    protected string loanType;
    protected int term;              
    protected double interestRate; 
    private string status = "PENDING";

    protected LoanApplication(string loanType, int term, double interestRate){
        this.loanType = loanType;
        this.term = term;
        this.interestRate = interestRate;
    }

    // Protected method – child classes can update status
    protected void SetStatus(string newStatus){
        status = newStatus;
    }

    // Public getter
    public string GetStatus(){
        return status;
    }

    // EMI calculation logic – can be overridden
    public virtual double CalculateEMI(Applicant applicant){
        double P = applicant.LoanAmount;               
        double R = interestRate / 12 / 100;            
        int N=term;
        return (P * R * Math.Pow(1 + R, N)) /
               (Math.Pow(1 + R, N) - 1);
    }
    // Abstract method
    public abstract bool ApproveLoan(Applicant applicant);
}
