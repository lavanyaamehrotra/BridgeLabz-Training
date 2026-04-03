public interface IBillingService
{
    void GenerateBill();
    void RecordPayment();
    void ViewOutstandingBills();
    void GenerateRevenueReport();
}
