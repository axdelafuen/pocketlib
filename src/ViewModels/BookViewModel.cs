using Model;

namespace ViewModels;

public class BookViewModel
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

    public string Status { get; set; }

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
        switch (Book.Status)
        {
            case Model.Status.Finished:
                Status = "Terminé";
                break;
            case Model.Status.Reading:
                Status = "En lecture";
                break;
            case Model.Status.NotRead:
                Status = "Non lu";
                break;
            case Model.Status.ToBeRead:
                Status = "A lire";
                break;
            case Model.Status.Unknown:
                Status = "Aucune information";
                break;
            default:
                Status = "Aucune information";
                break;
            
        }
    }
}