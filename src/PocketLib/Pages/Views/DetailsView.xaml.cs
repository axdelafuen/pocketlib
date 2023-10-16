namespace PocketLib.Pages.Views;

public partial class DetailsView : ContentView
{
    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(DetailsView));

    public string Image
    {
        get => GetValue(ImageProperty) as string;
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(DetailsView));

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty AuthorProperty = BindableProperty.Create("Author", typeof(string), typeof(DetailsView));

    public string Author
    {
        get => GetValue(AuthorProperty) as string;
        set => SetValue(AuthorProperty, value);
    }

    public static readonly BindableProperty ResumeProperty = BindableProperty.Create("Resume", typeof(string), typeof(DetailsView));

    public string Resume
    {
        get => GetValue(ResumeProperty) as string;
        set => SetValue(ResumeProperty, value);
    }

    public static readonly BindableProperty EditionProperty = BindableProperty.Create("Edition", typeof(string), typeof(DetailsView));

    public string Edition
    {
        get => GetValue(EditionProperty) as string;
        set => SetValue(EditionProperty, value);
    }

    public DetailsView()
	{
		InitializeComponent();
	}
}