// Interface defining mandatory loan operations
public interface IApprovable{
    // Method to approve or reject a loan
    bool ApproveLoan(Applicant applicant);
    // Method to calculate EMI
    double CalculateEMI(Applicant applicant);
}
