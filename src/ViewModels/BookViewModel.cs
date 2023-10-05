using Model;

namespace ViewModels;

public class BookViewModel
{
    private Book Book { get; set; }

    public string Title => Book.Title;

    public string ImageMedium => Book.ImageMedium;

    public List<Author> Authors => Book.Authors;

    public Author Author => Book.Authors[0];

    public Status Status => Book.Status;

    public float? UserRating => Book.UserRating;
    
    public BookViewModel(Book book)
    {
        Book = book;
    }
}