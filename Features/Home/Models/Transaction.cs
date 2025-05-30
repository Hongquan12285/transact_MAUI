namespace Transact;

public class Transaction
{
    public string AvatarText { get; set; } = null!;
    public string BackgroundColor { get; set; } = null!;
    public string TextColor { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Amount { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string StatusColor { get; set; } = null!;

    public string ImageSource =>
        AvatarText.EndsWith(".png") || AvatarText.EndsWith(".jpg") || AvatarText.EndsWith(".jpeg")
            ? AvatarText
            : null!;
}