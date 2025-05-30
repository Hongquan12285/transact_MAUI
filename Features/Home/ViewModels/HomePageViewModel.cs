namespace Transact;

public partial class HomePageViewModel : BaseViewModel
{
    private const int MaxVisibleItems = 4;

    public ObservableCollection<Transaction> Transactions { get; set; }
    public ObservableCollection<Transaction> VisibleTransactions { get; set; }
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SeeAllText))]
    private bool showAll;

    public string SeeAllText => ShowAll ? "Show Less" : "See All";

    [RelayCommand]
    public void ToggleSeeAll()
    {
        ShowAll = !ShowAll;
        VisibleTransactions.Clear();
        var items = ShowAll ? Transactions : Transactions.Take(MaxVisibleItems);
        foreach (var item in items)
        {
            VisibleTransactions.Add(item);
        }
    }

    public HomePageViewModel(IAppNavigator appNavigator) : base(appNavigator)
    {
        Transactions = new ObservableCollection<Transaction>(LoadTransactions());
        VisibleTransactions = new ObservableCollection<Transaction>(Transactions.Take(MaxVisibleItems));
    }

    private IEnumerable<Transaction> LoadTransactions()
    {
        return new List<Transaction>
        {
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },
            new Transaction { AvatarText = "sendmoney_icon.png", BackgroundColor = "#EEF2FF", TextColor = "#4154F1", Title = "Money Sent", Date = "1st Jan, 08:32 - YAKUBU PRECIOUS AGBA ", Description = "YAKUBU PRECIOUS AGBA", Amount = "₦58,250.00", Status = "Success", StatusColor = "Green" },
            new Transaction { AvatarText = "deposit_icon.png", BackgroundColor = "#F0FFF2", TextColor = "Green", Title = "Deposit", Date = "2nd Jan, 10:15 - YAKUBU PRECIOUS AGBA", Description = "JOHN DOE", Amount = "₦5,000.00", Status = "Failed", StatusColor = "Red" },

        };
    }
}
