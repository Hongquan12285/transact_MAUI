namespace Transact;

public class TransactionDetailModel
{
    public string Category { get; set; } = null!;
    public string Money { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string Bank { get; set; } = null!;
    public string AccountNo { get; set; } = null!;
    public string AccountName { get; set; } = null!;
    public string From { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string TransactionNumber { get; set; } = null!;
    public string Remark { get; set; } = null!;
}