namespace Transact;

public partial class HistoryPageViewModels(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] public ObservableCollection<EstimateModel> estimates;
    [ObservableProperty] public ObservableCollection<EstimateColumnModel> estimateColumns;
    [ObservableProperty] public int pageSelected;
    [ObservableProperty] public int pageSize;
    [ObservableProperty] public int pageNumber;
    [ObservableProperty] public int count;
    private ObservableCollection<EstimateModel> EstimatesData = [];
    private bool _toggle;

    public override Task OnAppearingAsync()
    {
        EstimateColumns =
        [
            new EstimateColumnModel { Time = "09/01", Deposit = 45800, Sent = 38900 },
            new EstimateColumnModel { Time = "16/01", Deposit = 28500, Sent = 22400 },
            new EstimateColumnModel { Time = "23/01", Deposit = 52300, Sent = 48600 },
            new EstimateColumnModel { Time = "30/01", Deposit = 15700, Sent = 12800 },
            new EstimateColumnModel { Time = "06/02", Deposit = 58900, Sent = 55400 },
            new EstimateColumnModel { Time = "13/02", Deposit = 32400, Sent = 28900 },
            new EstimateColumnModel { Time = "20/02", Deposit = 42600, Sent = 39500 },
            new EstimateColumnModel { Time = "27/02", Deposit = 19800, Sent = 15600 },
            new EstimateColumnModel { Time = "06/03", Deposit = 55300, Sent = 51200 },
            new EstimateColumnModel { Time = "13/03", Deposit = 23400, Sent = 19800 },
            new EstimateColumnModel { Time = "20/03", Deposit = 48900, Sent = 45300 },
            new EstimateColumnModel { Time = "27/03", Deposit = 35600, Sent = 31200 },
            new EstimateColumnModel { Time = "03/04", Deposit = 51200, Sent = 47800 },
            new EstimateColumnModel { Time = "10/04", Deposit = 29800, Sent = 25400 }
        ];
        EstimatesData =
        [
            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Waiting", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Deposit", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Failed", Direction = "Down"
            },

            new EstimateModel
            {
                Title = "Money Sent", User = "YAKUBU PRECIOUS AGBA", Time = "1st Jan, 08:32", Money = "₦58,250.00",
                Status = "Successful", Direction = "Up"
            }
        ];
        Count = EstimatesData.Count;
        PageNumber = 5;
        PageSize = 5;
        PageSelected = 1;

        return Task.CompletedTask;
    }

    private ObservableCollection<EstimateModel> GenerateEstimates()
    {
        var startIndex = (PageSelected - 1) * PageSize;
        return new ObservableCollection<EstimateModel>(EstimatesData.Skip(startIndex).Take(PageSize));
    }

    [RelayCommand]
    private void Filter() =>
        AppNavigator.NavigateAsync(AppRoutes.Filter).FireAndForget();

    [RelayCommand]
    private void PageSelect() => Estimates = GenerateEstimates();

    [RelayCommand]
    private void TransactionDetail()
    {
        if (_toggle)
            AppNavigator.NavigateAsync(UriHelper.StandardPath(AppRoutes.TransactionDetail), args: new TransactionDetailModel
            {
                Category = "Money Sent",
                Money = "N25,00.00",
                Status = "Successful",
                Bank = "Stanbic IBTC Bank",
                AccountNo = "9811008835",
                AccountName = "Yakubu Precious Agba",
                From = "Patricia Yakubu John",
                Date = "1st Jan, 2024 08:32",
                TransactionNumber = "9653016392746063",
                Remark = "Remark"
            }).FireAndForget();
        else
            AppNavigator.NavigateAsync(UriHelper.StandardPath(AppRoutes.TransactionDetail), args: new TransactionDetailModel
            {
                Category = "Money Sent",
                Money = "N25,00.00",
                Status = "Failed",
                Bank = "Stanbic IBTC Bank",
                AccountNo = "9811008835",
                AccountName = "Yakubu Precious Agba",
                From = "Patricia Yakubu John",
                Date = "1st Jan, 2024 08:32",
                TransactionNumber = "9653016392746063",
                Remark = "Medicine Payment"
            }).FireAndForget();
        _toggle = !_toggle;
    }
}