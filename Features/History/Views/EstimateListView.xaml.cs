namespace Transact;

public partial class EstimateListView : ContentView
{
    public EstimateListView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty EstimatesProperty = BindableProperty.Create(
        nameof(Estimates), typeof(ObservableCollection<EstimateModel>), typeof(EstimateListView)
    );

    public ObservableCollection<EstimateModel> Estimates
    {
        get => (ObservableCollection<EstimateModel>)GetValue(EstimatesProperty);
        set => SetValue(EstimatesProperty, value);
    }
}