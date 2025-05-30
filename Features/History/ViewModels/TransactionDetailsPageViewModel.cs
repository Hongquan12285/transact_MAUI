using Microsoft.Maui.Controls;

namespace Transact;

public partial class TransactionDetailsPageViewModel(
    IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] private TransactionDetailModel transactionDetail;
    [ObservableProperty] private string backPath;

    protected override void OnInit(IDictionary<string, object> query)
    {
        base.OnInit(query);
        var data = query.GetData<TransactionDetailModel>();
        if (data != null) TransactionDetail = data;
    }

    public override async Task OnAppearingAsync()
    {
        BackPath = GetLastSegmentOfUri();
        await base.OnAppearingAsync();
    }

    [RelayCommand]
    private async Task ShareDetail()
    {
        await Share.RequestAsync(new ShareTextRequest
        {
            Text = "Here are the filter details...",
            Title = "Share Filter Details"
        });
    }

    private static string GetLastSegmentOfUri()
    {
        var route = Shell.Current.CurrentState.Location.ToString();
        var segments = route.TrimStart('/').Split('/');

        if (segments.Length <= 0) return string.Empty;
        return segments.Last();
    }
}
