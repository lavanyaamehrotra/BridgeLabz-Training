// PersonalLoan inherits LoanApplication
public class PersonalLoan : LoanApplication{
    public PersonalLoan(int term, double interestRate): base("PERSONAL LOAN", term, interestRate) { }
    // Personal loan approval logic
    public override bool ApproveLoan(Applicant applicant){
        if (applicant.CreditScore >= 600 && applicant.Income >= 15000){
            SetStatus("APPROVED");
            return true;
        }
        SetStatus("REJECTED");
        return false;
    }
}
