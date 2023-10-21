using System.ComponentModel;
using System.Runtime.CompilerServices;
using Model;

namespace ViewModels;

public class BookViewModel : INotifyPropertyChanged
{
    private Book Book { get; set; }

    public string Title => Book.Title;

    public string Edition => Book.Publishers.First();

    public int NbPages => Book.NbPages;

    public Languages Language => Book.Language;

    public string ISBN13 => Book.ISBN13;
    
    public string ImageSmall => Book.ImageSmall;
    
    public string ImageMedium => Book.ImageMedium;
    
    public string ImageLarge => Book.ImageLarge;

    public List<AuthorViewModel> Authors { get; set; }

    public AuthorViewModel Author { get; set; }

    public Status Status
    {
        get => Book.Status;
        set
        {
            Book.Status = value;
            OnPropertyChanged();
        }
    }

    public float? UserRating => Book.UserRating;
    
    public BookViewModel(Book book)
    {
        Book = book;
        var bookAuthors = Book.Authors;
        var workAuthors = Book.Works.SelectMany(w => w.Authors);
        var authors = bookAuthors.Union(workAuthors).Distinct().ToList();
        Authors = new List<AuthorViewModel>();
        if (authors.Count == 0)
        {
            Author = new AuthorViewModel(new Author{Name="Unknown"});
            Authors.Add(Author);
        }
        else
        {
            foreach (var b in authors.Select(a => new AuthorViewModel(a)))
            {
                Authors.Add(b);            
            }
            Author = Authors.First();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}