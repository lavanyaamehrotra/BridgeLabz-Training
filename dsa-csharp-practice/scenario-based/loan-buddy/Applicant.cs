public class Applicant{
    // Private fields – encapsulatio
    private string name;
    private int creditScore;
    private double income;
    private double loanAmount;

    public Applicant(string name, int creditScore, double income, double loanAmount){
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    // Readonly properties
    public string Name => name;
    public int CreditScore => creditScore;
    public double Income => income;
    public double LoanAmount => loanAmount;
}
