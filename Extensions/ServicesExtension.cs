namespace Transact;

public static class ServicesExtension
{
    /// <summary>
    ///     Đăng ký những dịch vụ trong Core
    /// </summary>
    public static MauiAppBuilder RegisterCore(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IAppNavigator, AppNavigator>();
        return builder;
    }

    /// <summary>
    ///     Đăng ký những dịch vụ trong Features
    /// </summary>
    public static MauiAppBuilder RegisterFeatures(this MauiAppBuilder builder)
    {
        builder.RegisterDepositMoney();
        builder.RegisterHistory();
        return builder;
    }

    public static void RegisterRoute()
    {
        Routing.RegisterRoute("atmCard", typeof(ATMCardPage));
        Routing.RegisterRoute("bankTransfer", typeof(BankTransferPage));
        Routing.RegisterRoute("depositMoney", typeof(DepositMoneyPage));
        Routing.RegisterRoute("history", typeof(HistoryPage));
        Routing.RegisterRoute("successful", typeof(NotificationPopup));
        Routing.RegisterRoute("failure", typeof(NotificationPopup));
        Routing.RegisterRoute("filter", typeof(FilterPopup));
        Routing.RegisterRoute("transactionDetail", typeof(TransactionDetailsPage));
        Routing.RegisterRoute("MyAccount", typeof(MyAccountPage));
        Routing.RegisterRoute("Home", typeof(HomePage));
        Routing.RegisterRoute("intro", typeof(IntroPage));
        Routing.RegisterRoute("signUp", typeof(SignUpPage));
        Routing.RegisterRoute("signUpOtp", typeof(SignUpOtpPage));
        Routing.RegisterRoute("createPassword", typeof(CreatePasswordPage));
        Routing.RegisterRoute("login", typeof(LoginPage));
        Routing.RegisterRoute("forgotPassword", typeof(ForgotPasswordPage));
        Routing.RegisterRoute("myAccountMb", typeof(MyAccountMobile));
        Routing.RegisterRoute("setting", typeof(SettingPage));
        Routing.RegisterRoute("transactionPin", typeof(TransactionPinPageMobile));
        Routing.RegisterRoute("notificationPage", typeof(NotificationPageMobile));
        Routing.RegisterRoute("sendMoney", typeof(SendMoneyPage));
        Routing.RegisterRoute("otherBanks", typeof(OtherBanksPage));
        Routing.RegisterRoute("confirmDetails", typeof(ConfirmDetailsPage));
        Routing.RegisterRoute("transactionStatus", typeof(TransactionStatusPage));
        Routing.RegisterRoute("transactionStatusFailed", typeof(TransactionStatusFailedPage));
        Routing.RegisterRoute("transactionPinAndroid", typeof(TransactionPinPageAndroid));
        Routing.RegisterRoute("loadingSendMoney",typeof(LoadingSendMoneyPage));
        Routing.RegisterRoute("signUpOtpPopup", typeof(SignUpOtpPopup));
        Routing.RegisterRoute("createPasswordpopup", typeof(CreatePasswordPopup)); 
        Routing.RegisterRoute("myAccountMobile", typeof(MyAccountMobile)); 
    }

    /// <summary>
    ///     Đăng ký một số page/view không phải kế thừa từ các lớp base trong MVVM
    /// </summary>
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        var pageTypes = typeof(MauiProgram).Assembly
            .GetTypes()
            .Where(x =>
                !x.IsAbstract && x != typeof(BasePage) && x.IsAssignableTo(typeof(BasePage))
            );

        foreach (var pageType in pageTypes) builder.Services.AddTransient(pageType);

        var viewModelTypes = typeof(MauiProgram).Assembly
            .GetTypes()
            .Where(x =>
                !x.IsAbstract && x != typeof(BaseViewModel) &&
                x != typeof(NavigationAwareBaseViewModel) &&
                (
                    x.IsAssignableTo(typeof(BaseViewModel)) ||
                    x.IsAssignableTo(typeof(NavigationAwareBaseViewModel))
                )
            )
            .ToList();

        foreach (var vmType in viewModelTypes) builder.Services.AddTransient(vmType);

        return builder;
    }
}