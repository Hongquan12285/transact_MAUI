namespace Transact;

public partial class FilterPopup_Android : BasePopup
{
    public FilterPopup_Android(FilterPopupViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
    
}