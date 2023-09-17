namespace PocketLib.Pages;

public partial class SeparatorWithTitle : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(SeparatorWithTitle));

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    public SeparatorWithTitle()
	{
		InitializeComponent();
	}
}