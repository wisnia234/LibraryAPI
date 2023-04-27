namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/book")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetBook(Guid id)
        => Ok(await _bookService.GetBookByIdAsync(id));

    [HttpGet("books")]
    public async Task<IActionResult> GetAllBooks()
        => Ok(await _bookService.GetBooksAsync());

    [HttpPost("create")]
    public async Task<IActionResult> AddBook(CreateBook command)
        => Ok(await _bookService.CreateBookAsync(command with {Id = Guid.NewGuid()}));

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> UpdateBook(Guid id, UpdateBook command)
        => Ok(await _bookService.UpdateBookAsync(id,command));

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteBook(Guid id)
        => Ok(await _bookService.DeleteBookAsync(id));

}
