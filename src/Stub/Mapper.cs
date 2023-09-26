using LibraryDTO;
using Model;
using Utils;

namespace Stub;

static class Mapper
{
    internal static Mapper<Author, AuthorDTO> AuthorsMapper { get; } = new Mapper<Author, AuthorDTO>();
    internal static Mapper<Work, WorkDTO> WorksMapper { get; } = new Mapper<Work, WorkDTO>();
    internal static Mapper<Book, BookDTO> BooksMapper { get; } = new Mapper<Book, BookDTO>();

    internal static void Reset()
    {
        AuthorsMapper.Reset();
        WorksMapper.Reset();
        BooksMapper.Reset();
    }
}