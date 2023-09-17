namespace PocketLib.Pages;

public partial class ButtonViewNoHeaderImage : ContentView
{
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(ButtonViewNoHeaderImage));

    public string Label
    {
        get => GetValue(LabelProperty) as string;
        set => SetValue(LabelProperty, value);
    }

    public ButtonViewNoHeaderImage()
	{
		InitializeComponent();
	}
}