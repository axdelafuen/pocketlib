using System.Windows.Input;

namespace PocketLib.Pages;

public partial class ButtonViewNoChevron : ContentView
{
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(ButtonViewNoChevron));

    public string Label
    {
        get => GetValue(LabelProperty) as string;
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty ActionCommandProperty = BindableProperty.Create("ActionCommand", typeof(ICommand), typeof(ButtonViewNoChevron));

    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(ButtonViewNoChevron));

    public string Image
    {
        get => GetValue(ImageProperty) as string;
        set => SetValue(ImageProperty, value);
    }
    public ICommand ActionCommand
    {
        get => GetValue(ActionCommandProperty) as ICommand;
        set => SetValue(ActionCommandProperty, value);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (ActionCommand != null && ActionCommand.CanExecute(null))
        {
            ActionCommand.Execute(null);
        }
    }

    public ButtonViewNoChevron()
	{
		InitializeComponent();
	}
}