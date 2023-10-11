using Model;

namespace ViewModels;

public class BookViewModel
{
    private Book Book { get; set; }

    public string Title => Book.Title;

    public string ImageSmall => Book.ImageSmall;

    private List<Author> _authors;
    public List<Author> Authors
    {
        get
        {
            return _authors;
        }
        set
        {
            var bookAuthors = Book.Authors;
            var workAuthors = Book.Works.SelectMany(w => w.Authors);
            _authors = bookAuthors.Union(workAuthors).Distinct().ToList();
        }
    }
    public Status Status => Book.Status;

    public float? UserRating => Book.UserRating;
    
    public BookViewModel(Book book)
    {
        Book = book;
    }
}