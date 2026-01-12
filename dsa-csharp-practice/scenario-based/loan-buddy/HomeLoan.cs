// HomeLoan inherits LoanApplication
public class HomeLoan : LoanApplication{
    public HomeLoan(int term, double interestRate): base("HOME LOAN", term, interestRate) { }

    public override bool ApproveLoan(Applicant applicant){
        if (applicant.CreditScore >= 700 && applicant.Income >= 30000){
            SetStatus("APPROVED");
            return true;
        }
        SetStatus("REJECTED");
        return false;
    }
    // Polymorphism
    public override double CalculateEMI(Applicant applicant){
        return base.CalculateEMI(applicant) - 500;
    }
}
