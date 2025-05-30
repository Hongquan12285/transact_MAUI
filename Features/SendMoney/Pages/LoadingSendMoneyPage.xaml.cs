namespace Transact;

public partial class LoadingSendMoneyPage
{
    //private float _startAngle = 0; // Start angle for the spinner
    //private readonly float _arcLength = 90; // Length of the arc (in degrees)
    //private readonly float _rotationSpeed = 5; // Speed of rotation

    public LoadingSendMoneyPage()
	{
		InitializeComponent();
        StartReverseRotation();
    }

	protected override async void OnAppearing()
	{
        base.OnAppearing();

		await Task.Delay(3000);

        await Application.Current.MainPage.Navigation.PushAsync(new TransactionStatusPageAndroid());
    }

    private async void StartReverseRotation()
    {
        while (true)
        {
            // Xoay ngược chiều kim đồng hồ (giá trị âm)
            await LoadingImage.RotateTo(-360, 1000);
            LoadingImage.Rotation = 0; // Đặt lại góc xoay về 0
        }
    }
}
