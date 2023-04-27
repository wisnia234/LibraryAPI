namespace Application.Services;

public interface IBookService
{
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<BookDTO> GetBookByIdAsync(Guid id);
    Task<Guid> UpdateBookAsync(Guid id, UpdateBook command);
    Task<Guid> DeleteBookAsync(Guid id);
    Task<Guid> CreateBookAsync(CreateBook command);

}
