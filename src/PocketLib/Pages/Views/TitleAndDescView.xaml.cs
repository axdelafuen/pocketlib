namespace PocketLib.Pages.Views;

public partial class TitleAndDescView : ContentView
{

    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(TitleAndDescView));

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }
    public static readonly BindableProperty DescProperty = BindableProperty.Create("Desc", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string Desc
    {
        get => GetValue(DescProperty) as string;
        set => SetValue(DescProperty, value);
    }

    public static readonly BindableProperty AttributeTitle1Property = BindableProperty.Create("AttributeTitle1", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeTitle1
    {
        get => GetValue(AttributeTitle1Property) as string;
        set => SetValue(AttributeTitle1Property, value);
    }

    public static readonly BindableProperty AttributeTitle2Property = BindableProperty.Create("AttributeTitle2", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeTitle2
    {
        get => GetValue(AttributeTitle2Property) as string;
        set => SetValue(AttributeTitle2Property, value);
    }

    public static readonly BindableProperty AttributeTitle3Property = BindableProperty.Create("AttributeTitle3", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeTitle3
    {
        get => GetValue(AttributeTitle3Property) as string;
        set => SetValue(AttributeTitle3Property, value);
    }

    public static readonly BindableProperty AttributeDesc1Property = BindableProperty.Create("AttributeDesc1", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeDesc1
    {
        get => GetValue(AttributeDesc1Property) as string;
        set => SetValue(AttributeDesc1Property, value);
    }

    public static readonly BindableProperty AttributeDesc2Property = BindableProperty.Create("AttributeDesc2", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeDesc2
    {
        get => GetValue(AttributeDesc2Property) as string;
        set => SetValue(AttributeDesc2Property, value);
    }

    public static readonly BindableProperty AttributeDesc3Property = BindableProperty.Create("AttributeDesc3", typeof(string), typeof(TitleAndDescView), string.Empty);

    public string AttributeDesc3
    {
        get => GetValue(AttributeDesc3Property) as string;
        set => SetValue(AttributeDesc3Property, value);
    }

    public TitleAndDescView()
	{
        InitializeComponent();
	}
}