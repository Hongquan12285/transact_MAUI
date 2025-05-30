namespace Transact;

public partial class PaginationControl : ContentView
{
    private int PageCount;

    public PaginationControl()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    public static readonly BindableProperty PageArrayListProperty = BindableProperty.Create(
        nameof(PageArrayList), typeof(ObservableCollection<PageModel>), typeof(PaginationControl),
        new ObservableCollection<PageModel>()
    );

    public ObservableCollection<PageModel> PageArrayList
    {
        get => (ObservableCollection<PageModel>)GetValue(PageArrayListProperty);
        private set => SetValue(PageArrayListProperty, value);
    }

    public static readonly BindableProperty PageSizeProperty = BindableProperty.Create(
        nameof(PageSize), typeof(int), typeof(PaginationControl), 5
    );

    public int PageSize
    {
        get => (int)GetValue(PageSizeProperty);
        set => SetValue(PageSizeProperty, value);
    }

    public static readonly BindableProperty PageNumberProperty = BindableProperty.Create(
        nameof(PageNumber), typeof(int), typeof(PaginationControl)
    );

    public int PageNumber
    {
        get => (int)GetValue(PageNumberProperty);
        set => SetValue(PageNumberProperty, value);
    }

    public static readonly BindableProperty CountProperty = BindableProperty.Create(
        nameof(Count), typeof(int), typeof(PaginationControl)
    );

    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public static readonly BindableProperty PageSelectedProperty = BindableProperty.Create(
        nameof(PageSelected), typeof(int), typeof(PaginationControl), 1, BindingMode.TwoWay,
        propertyChanged: OnPageSelectChanged
    );

    public int PageSelected
    {
        get => (int)GetValue(PageSelectedProperty);
        set => SetValue(PageSelectedProperty, value);
    }

    public static readonly BindableProperty PageSelectCommandProperty = BindableProperty.Create(
        nameof(PageSelectCommand), typeof(ICommand), typeof(PaginationControl)
    );

    public ICommand PageSelectCommand
    {
        get => (ICommand)GetValue(PageSelectCommandProperty);
        set => SetValue(PageSelectCommandProperty, value);
    }

    private static void OnPageSelectChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (PaginationControl)bindable;
        control.PageArrayList = control.GeneratePaging();
        control.PageSelectCommand?.Execute(newValue);
    }

    private void OnLoaded(object? sender, EventArgs e)
    {
        PageCount = (int)Math.Ceiling((double)Count / PageSize);
        PageArrayList = GeneratePaging();
    }

    private ObservableCollection<PageModel> GeneratePaging()
    {
        var selectedItem = new PageModel(PageSelected, true);
        var pages = new ObservableCollection<PageModel> { selectedItem };
        var toggleLoop = true;
        var addLeft = 1;
        var addRight = 1;
        while (pages.Count < PageNumber && pages.Count < PageCount)
        {
            if (toggleLoop)
            {
                if (PageSelected - addLeft >= 1)
                {
                    var selectedIndex = pages.IndexOf(selectedItem);
                    pages.Insert(selectedIndex - addLeft + 1, new PageModel(PageSelected - addLeft));
                    addLeft++;
                }
            }
            else
            {
                if (PageSelected + addRight <= PageCount)
                {
                    var selectedIndex = pages.IndexOf(selectedItem);
                    pages.Insert(selectedIndex + addRight, new PageModel(PageSelected + addRight));
                    addRight++;
                }
            }

            toggleLoop = !toggleLoop;
        }

        return pages;
    }

    private void OnPageTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Border border) return;
        var label = border.FindByName<Label>("Text");
        PageSelected = int.Parse(label.Text);
    }

    private void PagePrevious(object? sender, TappedEventArgs e)
    {
        if (PageSelected - 1 < 1) return;
        PageSelected--;
    }

    private void PageNext(object? sender, TappedEventArgs e)
    {
        if (PageSelected + 1 > PageCount) return;
        PageSelected++;
    }
}