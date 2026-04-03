// AutoLoan inherits LoanApplication
public class AutoLoan : LoanApplication{
    public AutoLoan(int term, double interestRate): base("AUTO LOAN", term, interestRate) { }

    // Auto loan approval logic
    public override bool ApproveLoan(Applicant applicant){
        if (applicant.CreditScore >= 650 && applicant.Income >= 20000){
            SetStatus("APPROVED");
            return true;
        }
        SetStatus("REJECTED");
        return false;
    }
}
