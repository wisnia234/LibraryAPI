using Infrastructure.Context;
namespace Infrastructure.Repsoitory;

internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbContext.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        => await _dbSet.Where(predicate).ToListAsync();


    public async Task<TEntity?> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
        => await _dbSet.FirstOrDefaultAsync(predicate);

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _dbSet.ToListAsync();


    public async Task<TEntity?> GetByIdAsync(Guid id)
        => await _dbSet.FindAsync(id);
    

    public async Task RemoveAsync(TEntity entity)
    {
        _dbContext.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
