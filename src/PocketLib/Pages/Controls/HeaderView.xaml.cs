namespace PocketLib.Pages;

public partial class HeaderView : ContentView
{
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(string));

    public string Label
    {
        get => GetValue(LabelProperty) as string;
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty Image1Property = BindableProperty.Create("Image1", typeof(string), typeof(string));

    public string Image1
    {
        get => GetValue(Image1Property) as string;
        set => SetValue(Image1Property, value);
    }

    public static readonly BindableProperty Image2Property = BindableProperty.Create("Image2", typeof(string), typeof(string));

    public string Image2
    {
        get => GetValue(Image2Property) as string;
        set => SetValue(Image2Property, value);
    }

    public HeaderView()
	{
		InitializeComponent();
	}
}