using System.Windows.Input;

namespace PocketLib.Pages.Views;

public partial class ButtonView : ContentView
{
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(ButtonView));
    
    public string Label
	{
        get => GetValue(LabelProperty) as string;
        set => SetValue(LabelProperty, value);
    }

    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(ButtonView));

    public string Image
    {
        get => GetValue(ImageProperty) as string;
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty CountProperty = BindableProperty.Create("Count", typeof(string), typeof(ButtonView), string.Empty);

    public string Count
    {
        get => GetValue(CountProperty) as string;
        set => SetValue(CountProperty, value);
    }

    public static readonly BindableProperty ActionCommandProperty = BindableProperty.Create("ActionCommand", typeof(ICommand), typeof(ButtonView));

    public ICommand ActionCommand 
    {
        get => GetValue(ActionCommandProperty) as ICommand;
        set => SetValue(ActionCommandProperty, value);
    }

    public static readonly BindableProperty ActionCommandParameterProperty = BindableProperty.Create("ActionCommandParameter", typeof(object), typeof(ButtonView));

    public object ActionCommandParameter
    {
        get => GetValue(ActionCommandParameterProperty) as object;
        set => SetValue(ActionCommandParameterProperty, value);
    }

    public ButtonView()
    {
        InitializeComponent();
    }
}