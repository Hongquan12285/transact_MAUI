namespace Transact;

public class TransactionStatusModel
{
    public string Caption { get; set; } = null!;
    public string Note { get; set; } = null!;
    public string Money { get; set; } = null!;
    public bool IsSuccess { get; set; }
}