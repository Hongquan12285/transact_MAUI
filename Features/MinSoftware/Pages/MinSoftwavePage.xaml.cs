namespace Transact
{
    public partial class MinSoftwavePage : ContentPage
    {
        public MinSoftwavePage(MaxCareViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}