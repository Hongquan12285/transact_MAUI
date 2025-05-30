namespace Transact;

public class TransactionDetail
{
    public string Amount { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string Bank { get; set; } = null!;
    public string AccountNumber { get; set; } = null!;
    public string AccountName { get; set; } = null!;
    public string From { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string TransactionNumber { get; set; } = null!;
    public string Remark { get; set; } = null!;
}