using System.Windows.Input;
using Model;

namespace PocketLib.Pages.Views;

public partial class PreviewView : ContentView
{
    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(PreviewView));

    public string Image
    {
        get => GetValue(ImageProperty) as string;
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(PreviewView));

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }
    
    public static readonly BindableProperty AuthorProperty = BindableProperty.Create("Author", typeof(string), typeof(PreviewView));

    public string Author
    {
        get => GetValue(AuthorProperty) as string;
        set => SetValue(AuthorProperty, value);
    }

    public static readonly BindableProperty StatusProperty = BindableProperty.Create("Status", typeof(Status), typeof(PreviewView));

    public string Status
    {
        get => GetValue(StatusProperty).ToString();
        set => SetValue(StatusProperty, value);
    }

    public static readonly BindableProperty ActionCommandProperty = BindableProperty.Create("ActionCommand", typeof(ICommand), typeof(PreviewView));

    public ICommand ActionCommand
    {
        get => GetValue(ActionCommandProperty) as ICommand;
        set => SetValue(ActionCommandProperty, value);
    }
    
    public static readonly BindableProperty ActionCommandParameterProperty = BindableProperty.Create("ActionCommandParameter", typeof(object), typeof(PreviewView));

    public object ActionCommandParameter
    {
        get => GetValue(ActionCommandParameterProperty) as object;
        set => SetValue(ActionCommandParameterProperty, value);
    }
    
    public PreviewView()
    {
        InitializeComponent();
    }

}