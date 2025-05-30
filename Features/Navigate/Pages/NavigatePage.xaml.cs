namespace Transact;

public partial class NavigatePage : BasePage
{
    public NavigatePage(NavigatePageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}