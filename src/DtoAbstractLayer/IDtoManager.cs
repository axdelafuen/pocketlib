using LibraryDTO;

namespace DtoAbstractLayer;

public interface IDtoManager
{

    Task<BookDTO> GetBookById(string id);

    Task<BookDTO> GetBookByISBN(string isbn);

    Task<Tuple<long, IEnumerable<BookDTO>>> GetBooksByTitle(string title, int index, int count, string sort = "");
    
    Task<Tuple<long, IEnumerable<BookDTO>>> GetBooksByAuthorId(string authorId, int index, int count, string sort = "");

    Task<Tuple<long, IEnumerable<BookDTO>>> GetBooksByAuthor(string author, int index, int count, string sort = "");

    Task<AuthorDTO> GetAuthorById(string id);

    Task<Tuple<long, IEnumerable<AuthorDTO>>> GetAuthorsByName(string substring, int index, int count, string sort = "");
}