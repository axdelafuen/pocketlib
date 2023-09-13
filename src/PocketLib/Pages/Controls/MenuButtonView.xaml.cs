namespace PocketLib.Pages;

public partial class MenuButtonView : ContentView
{
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(string));
    
    public string Label
	{
        get => GetValue(LabelProperty) as string;
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(string));

    public string Image
    {
        get => GetValue(ImageProperty) as string;
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty CountProperty = BindableProperty.Create("Count", typeof(string), typeof(string));

    public string Count
    {
        get => GetValue(CountProperty) as string;
        set => SetValue(CountProperty, value);
    }

    public MenuButtonView()
    {
        InitializeComponent();
    }

}