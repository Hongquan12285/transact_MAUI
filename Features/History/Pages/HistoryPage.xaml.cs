namespace Transact;

public partial class HistoryPage : BasePage
{
    public HistoryPage(HistoryPageViewModels vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}