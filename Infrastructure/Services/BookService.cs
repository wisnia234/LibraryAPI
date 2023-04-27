namespace Application.Services;

public sealed class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Guid> CreateBookAsync(CreateBook command)
    {

        Book newBook = new(command.Id, command.Title, command.Author, command.Description, DateTime.Now.Date);        
        await _bookRepository.AddAsync(newBook);

        return newBook.Id;
    }

    public async Task<Guid> DeleteBookAsync(Guid id)
    {
        var book = await _bookRepository.GetByIdAsync(id);
        await _bookRepository.RemoveAsync(book);

        return book.Id;
    }

    public async Task<BookDTO> GetBookByIdAsync(Guid id)
    {
        var book = await _bookRepository.GetByIdAsync(id);

        return new BookDTO() {Title = book.Title, Description = book.Description, Author = book.Author };
    }
           

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        return await _bookRepository.GetAllAsync();
    }

    public async Task<Guid> UpdateBookAsync(Guid id, UpdateBook command)
    {
        var book = await _bookRepository.GetByIdAsync(id);
        book = new(id, command.Title, command.Description, command.Author, DateTime.Now.Date);
        await _bookRepository.UpdateAsync(book);

        return book.Id;
    }

    
}
