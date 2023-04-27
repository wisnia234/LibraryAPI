
namespace Infrastructure.Repsoitory;

internal sealed class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
