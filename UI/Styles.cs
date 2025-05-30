using Microsoft.Maui.Controls.Shapes;
using Syncfusion.Maui.Toolkit.NumericEntry;
using Telerik.Maui.Controls;

namespace Transact;

public static partial class Styles
{
    static readonly Color TextPrimaryColor = AppColors.Black;
    static readonly double PopupCornerRadius = 32;

    // Style cho Label Change 
    public static readonly Style LabelChange = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, Dimens.FontSize18)
        .Set(Label.TextColorProperty, AppColors.Gradient)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular)
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.End)
        .Set(Grid.ColumnProperty, 2);

    //lable myaccount 
    public static readonly Style LableMyAccount = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, Dimens.FontSize18)
        .Set(Label.TextColorProperty, AppColors.Gradient)
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.PaddingProperty, new Thickness(10))
        .Set(Label.FontFamilyProperty, FontNames.InterRegular)
        .Set(Grid.ColumnProperty, 1);

    //lable myaccount 
    public static readonly Style LableSetting = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, Dimens.FontSizeH5)
        .Set(Label.TextColorProperty, AppColors.Gradient)
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular)
        .Set(Grid.ColumnProperty, 1);
    //icon myaccount 
    public static readonly Style IconMyAccount = CreateStyle<Image>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Spacing24)
        .Set(VisualElement.WidthRequestProperty, Dimens.Spacing24)
        .Set(View.VerticalOptionsProperty, LayoutOptions.Center);
    // lable Gray
    public static readonly Style LabelGray = CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.Gray)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);
    // lable Gradent
    public static readonly Style LabelGradent = CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.Gradient)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);
    // lable primary
    public static readonly Style LabelGrey = CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.Grey)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);
    // lable primary
    public static readonly Style Labelprimary = CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.primarytext)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);
    // lable white
    public static readonly Style Labelwhite= CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.White)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);
    // label page title
    public static readonly Style LabelStyle = CreateStyle<Label>()
        .Set(Label.PaddingProperty, new Thickness(0, Dimens.Spacing24, 0, Dimens.Spacing24))
        .Set(Label.FontSizeProperty, Dimens.FontSizeH5)
        .Set(Label.FontFamilyProperty, FontNames.InterMedium)
        .Set(Label.TextColorProperty, AppColors.primarytext)
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);

    // Popup Outer Border Style
    public static readonly Style OuterBorderStyle = CreateStyle<Border>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.bgpopup)
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(PopupCornerRadius)
        })
        .Set(VisualElement.WidthRequestProperty, 500)
        .Set(VisualElement.HeightRequestProperty, 740);

    // Popup Inner Border Style
    public static readonly Style InnerBorderStyle = CreateStyle<Border>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.White)
        .Set(Border.StrokeProperty, AppColors.clstoke)
        .Set(Border.StrokeThicknessProperty, 1)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(PopupCornerRadius)
        })
        .Set(VisualElement.WidthRequestProperty, 480)
        .Set(VisualElement.HeightRequestProperty, 720)
        .Set(Border.PaddingProperty, new Thickness(20));


    // Header Label Style
    public static readonly Style HeaderLabelStyle = CreateStyle<Label>()
        .Set(Label.TextColorProperty, AppColors.Gradient)
        .Set(Label.FontSizeProperty, 20)
        .Set(View.MarginProperty, new Thickness(90, 0, 0, 0))
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);

    // Image Close Button Style
    public static readonly Style CloseImageStyle = CreateStyle<Image>()
        .Set(VisualElement.WidthRequestProperty, 24)
        .Set(VisualElement.HeightRequestProperty, 24)
        .Set(View.MarginProperty, new Thickness(70, 0, 0, 0))
        .Set(View.HorizontalOptionsProperty, LayoutOptions.End);

    // Popup Logo Style
    public static readonly Style LogoImageStyle = CreateStyle<Image>()
        .Set(VisualElement.WidthRequestProperty, 88)
        .Set(VisualElement.HeightRequestProperty, 94)
        .Set(View.MarginProperty, new Thickness(0, 20, 0, 20))
        .Set(View.HorizontalOptionsProperty, LayoutOptions.Center);

    // Complete Button Style
    public static readonly Style CompleteButtonStyle = CreateStyle<Button>()
        .Set(Button.TextColorProperty, Colors.White)
        .Set(Button.FontSizeProperty, 18)
        .Set(Button.CornerRadiusProperty, 12)
        .Set(VisualElement.HeightRequestProperty, 50)
        .Set(View.MarginProperty, new Thickness(0, 10, 0, 10));

    // Terms Label Style
    public static readonly Style TermsLabelStyle = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, 12)
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.LineBreakModeProperty, LineBreakMode.WordWrap)
        .Set(View.MarginProperty, new Thickness(0, 10, 0, 0));

    // Instruction Text Style
    public static readonly Style InstructionTextStyle = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, 12)
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.LineBreakModeProperty, LineBreakMode.WordWrap)
        .Set(View.MarginProperty, new Thickness(0, 0, 0, 10));

    // Styles base cho Label
    public static readonly Style BaseLabel = CreateStyle<Label>()
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(Label.TextColorProperty, TextPrimaryColor)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH6)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);

    public static readonly Style InputLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel);

    public static readonly Style FilterLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontFamilyProperty, FontNames.InterBold)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH5)
        .Set(Label.FontAttributesProperty, FontAttributes.Bold);

    public static readonly Style TitlePageLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH5)
        .Set(Label.FontFamilyProperty, FontNames.InterRegular);

    public static readonly Style TitlePageOtherLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH4)
        .Set(Label.TextColorProperty, AppColors.Blue);

    public static readonly Style CaptionFormLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH4);

    public static readonly Style DescriptionFormLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel);

    public static readonly Style RegularLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel);

    public static readonly Style MediumLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontFamilyProperty, FontNames.InterMedium);

    public static readonly Style BoldLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.FontAttributesProperty, FontAttributes.Bold)
        .Set(Label.FontFamilyProperty, FontNames.InterBold);

    public static readonly Style TitleLabel = CreateStyle<Label>()
        .BaseOn(MediumLabel)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH5);

    public static readonly Style NoteLabel = CreateStyle<Label>()
        .BaseOn(RegularLabel)
        .Set(Label.TextColorProperty, AppColors.Grey)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH8);

    public static readonly Style LinkLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.TextColorProperty, AppColors.LinkBlue)
        .Set(Label.TextDecorationsProperty, TextDecorations.Underline)
        .Set(Label.FontAttributesProperty, FontAttributes.Italic)
        .Set(Label.FontFamilyProperty, FontNames.InterItalic);

    public static readonly Style ErrorLabel = CreateStyle<Label>()
        .BaseOn(BaseLabel)
        .Set(Label.TextColorProperty, AppColors.Red)
        .Set(Label.FontSizeProperty, Dimens.FontSizeH7);

    // Styles base cho Button
    public static readonly Style BaseButton = CreateStyle<Button>()
        .Set(Button.CornerRadiusProperty, 4);

    public static readonly Style TextButton = CreateStyle<Button>()
        .BaseOn(BaseButton)
        .Set(Button.FontSizeProperty, Dimens.FontSizeH6)
        .Set(Button.BorderWidthProperty, 0)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height42)
        .Set(Button.TextColorProperty, AppColors.White)
        .Set(Button.FontFamilyProperty, FontNames.InterRegular);
    // Styles Button Login
    public static readonly Style BaseButtonLogin = CreateStyle<Button>()
        .Set(Button.FontSizeProperty, Dimens.FontSizeH6)
        .Set(Button.CornerRadiusProperty, 5)
        .Set(Button.BorderWidthProperty, 0)
        .Set(VisualElement.HeightRequestProperty, Dimens.Spacing42)
        .Set(VisualElement.WidthRequestProperty, Dimens.Spacing380)
        .Set(Button.TextColorProperty, AppColors.White)
        .Set(Button.FontFamilyProperty, FontNames.InterRegular);
    // Styles button skip, next..
    public static readonly Style NextButton = CreateStyle<Button>()
        .Set(Button.FontSizeProperty, Dimens.FontSizeH6)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height42)
        .Set(Button.TextColorProperty, AppColors.Blue)
        .Set(Button.FontFamilyProperty, FontNames.InterRegular);
    // Styles button login, sign up, forgot
    public static readonly Style ForgotButton = CreateStyle<Button>()
        .Set(Button.FontSizeProperty, Dimens.FontSizeH7)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height18)
        .Set(Button.TextColorProperty, AppColors.TextBlue)
        .Set(Button.FontFamilyProperty, FontNames.InterRegular);

    public static readonly Style TextOutlineButton = CreateStyle<Button>()
        .BaseOn(BaseButton)
        .Set(Button.BorderWidthProperty, 1)
        .Set(Button.BorderColorProperty, AppColors.Blue)
        .Set(Button.FontSizeProperty, Dimens.FontSizeH6)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height42)
        .Set(Button.TextColorProperty, AppColors.Blue)
        .Set(Button.FontFamilyProperty, FontNames.InterRegular);

    public static readonly Style IconButton = CreateStyle<Button>()
        .BaseOn(BaseButton)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height40)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width40);

    // Styles base cho Border
    public static readonly Style RectangleCornerFrame = CreateStyle<Border>()
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(16)
        });

    public static readonly Style LogoPopupFrame = CreateStyle<Border>()
        .Set(Border.PaddingProperty, new Thickness(11))
        .Set(VisualElement.BackgroundColorProperty, AppColors.White)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height40)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width40)
        .Set(Border.StrokeThicknessProperty, 0);

    public static readonly Style IconFrame = CreateStyle<Border>()
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(VisualElement.HeightRequestProperty, Dimens.IconWidth)
        .Set(VisualElement.WidthRequestProperty, Dimens.IconWidth)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(Dimens.IconWidth * 2)
        });
    // Styles Border Login
    public static readonly Style IconFrameLogin = CreateStyle<Border>()
        .Set(Border.StrokeThicknessProperty, 20)
        .Set(Border.StrokeProperty, AppColors.BorderColor)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(Dimens.BorderPopWidth * 2)
        })
        .Set(VisualElement.HeightRequestProperty, Dimens.Height740)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width548)
        .Set(VisualElement.BackgroundColorProperty,AppColors.BackgroundWhite);
    // Styles intro gridview login
    public static readonly Style IntroLogin = CreateStyle<Grid>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Height94)
        .Set(VisualElement.WidthRequestProperty, Dimens.FormWidth);
    // Styles intro img
    public static readonly Style IntroImg = CreateStyle<Image>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Height240)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width328);

    public static readonly Style EstimateCardFrame = CreateStyle<Border>()
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(VisualElement.BackgroundColorProperty, AppColors.White)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(Dimens.Spacing12)
        });

    public static readonly Style PagingFrame = CreateStyle<Border>()
        .Set(Border.StrokeThicknessProperty, 2)
        .Set(Border.StrokeProperty, Colors.Transparent)
        .Set(VisualElement.HeightRequestProperty, Dimens.Height24)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width24)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(2)
        });

    // Styles base cho Image
    public static readonly Style BaseIcon = CreateStyle<Image>()
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(VisualElement.HeightRequestProperty, Dimens.Width16)
        .Set(VisualElement.WidthRequestProperty, Dimens.Height16);
    // Styles base cho Shadow

    // Styles base cho Entry
    public static readonly Style NumericEntry = CreateStyle<SfNumericEntry>()
        .Set(VisualElement.HeightRequestProperty, Dimens.EntryHeight)
        .Set(SfNumericEntry.TextColorProperty, AppColors.Black)
        .Set(SfNumericEntry.PlaceholderColorProperty, AppColors.PlaceholderGrey)
        .Set(SfNumericEntry.FontFamilyProperty, FontNames.InterRegular)
        .Set(SfNumericEntry.ShowBorderProperty, false)
        .Set(SfNumericEntry.ShowClearButtonProperty, false)
        .Set(SfNumericEntry.FontSizeProperty, Dimens.FontSizeH5);

    public static readonly Style TextEntry = CreateStyle<Entry>()
        .Set(VisualElement.HeightRequestProperty, Dimens.EntryHeight)
        .Set(Entry.TextColorProperty, AppColors.Black)
        .Set(Entry.PlaceholderColorProperty, AppColors.PlaceholderGrey)
        .Set(Entry.FontFamilyProperty, FontNames.InterRegular)
        .Set(Entry.FontSizeProperty, Dimens.FontSizeH5);

    public static readonly Style OtpEntry = CreateStyle<Entry>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Spacing50)
        .Set(VisualElement.WidthRequestProperty, Dimens.Spacing50)
        .Set(InputView.MaxLengthProperty, 1)
        .Set(VisualElement.BackgroundColorProperty, AppColors.BackgroundWhite)
        .Set(Entry.FontFamilyProperty, FontNames.InterRegular)
        .Set(Entry.FontSizeProperty, Dimens.FontSizeH4);

    public static readonly Style PasswordEntry = CreateStyle<Entry>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Spacing50)
        .Set(VisualElement.BackgroundColorProperty, AppColors.BackgroundWhite)
        .Set(Entry.FontFamilyProperty, FontNames.InterRegular)
        .Set(Entry.FontSizeProperty, Dimens.FontSize18);

    // Styles base cho Popup
    public static readonly Style PopupFrame = CreateStyle<Border>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.White)
        .Set(Border.StrokeProperty, AppColors.PopBorder)
        .Set(Border.StrokeThicknessProperty, Dimens.BorderPopWidth)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(24)
        });

    public static readonly Style PopupOtherFrame = CreateStyle<Border>()
        .Set(VisualElement.BackgroundColorProperty, AppColors.PopOtherBackground)
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(16, 16, 0, 0)
        });

    // Styles base cho BoxView
    public static readonly Style RectangleBoxView = CreateStyle<BoxView>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Height16)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width16);
    
    [Obsolete("Obsolete")] public static readonly Style OverLayBoxView = CreateStyle<BoxView>()
        .Set(VisualElement.BackgroundColorProperty, Colors.Transparent)
        .Set(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand)
        .Set(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);


    // Style cho entry transaction pin
    public static readonly Style EntryTransactionPin = CreateStyle<Entry>()
        .Set(VisualElement.HeightRequestProperty, Dimens.Height58)
        .Set(VisualElement.WidthRequestProperty, Dimens.Width52)
        .Set(Entry.TextColorProperty, AppColors.Blue)
        .Set(Entry.FontSizeProperty,Dimens.FontSizeH4)
        .Set(Entry.MaxLengthProperty,1);
}

/// <summary>
/// Những phương thức base của styles
/// </summary>
public static partial class Styles
{
    private static Style CreateStyle<T>()
    {
        return new Style(typeof(T));
    }

    private static Style BaseOn(this Style style, Style basedOn)
    {
        style.BasedOn = basedOn;
        return style;
    }

    private static Style Set(this Style style, BindableProperty property, object value)
    {
        style.Setters.Add(new Setter
        {
            Property = property,
            Value = value
        });
        return style;
    }

    private static Style BindTrigger(this Style style, Binding binding, object value,
        params (BindableProperty p, object value)[] setters)
    {
        var dataTrigger = new DataTrigger(style.TargetType)
        {
            Binding = binding,
            Value = value
        };

        for (var i = 0; i < setters.Length; i++)
            dataTrigger.Setters.Add(new Setter
            {
                Property = setters[i].p,
                Value = setters[i].value
            });

        style.Triggers.Add(dataTrigger);

        return style;
    }
}