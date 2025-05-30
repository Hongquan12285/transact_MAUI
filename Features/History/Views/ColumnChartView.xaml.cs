namespace Transact;

public partial class ColumnChartView : ContentView
{
    public ColumnChartView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty SeriesProperty = BindableProperty.Create(
        nameof(Series), typeof(ObservableCollection<EstimateColumnModel>), typeof(ColumnChartView)
    );

    public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
        nameof(Caption), typeof(string), typeof(ConfirmTransferView), null,
        BindingMode.TwoWay
    );

    public ObservableCollection<EstimateColumnModel> Series
    {
        get => (ObservableCollection<EstimateColumnModel>)GetValue(SeriesProperty);
        set => SetValue(SeriesProperty, value);
    }

    public string Caption
    {
        get => (string)GetValue(CaptionProperty);
        set => SetValue(CaptionProperty, value);
    }
}