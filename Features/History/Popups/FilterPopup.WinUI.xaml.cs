namespace Transact;

public partial class FilterPopup_WinUI : BasePopup
{
    public FilterPopup_WinUI(FilterPopupViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}