using Model;

namespace ViewModels;

public class AuthorViewModel
{
    private Author Author { get; set; }

    public string Name => Author.Name;
    
    public AuthorViewModel(Author author)
    {
        Author = author;
    }
}