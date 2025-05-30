namespace Transact;

public partial class BalanceView : ContentView
{
	public BalanceView()
	{
		InitializeComponent();
	}
    private bool isBalanceVisible = false;
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        isBalanceVisible = !isBalanceVisible;

        // Cập nhật số dư hiển thị hoặc ẩn
        BalanceLabel.Text = isBalanceVisible ? "₦ 28,085.00" : "****";

        // Đổi biểu tượng mắt
        EyeIcon.Source = isBalanceVisible ? "eye.png" : "eye_off.png";
    }
}