namespace myHr.persistence.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class 
{
    protected readonly DbContext _dbContext;
    public GenericRepository(DbContext DbContext)
    {
        _dbContext = DbContext;
    }

    public async Task<Result> CreateAsync(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Entry(entity).State = EntityState.Added;
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Result.Ok();
    }

    public Task<Result> DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<IEnumerable<T>>> GetAllAsync(CancellationToken cancellationToken)
    {
        var data = await _dbContext.Set<T>().AsNoTracking().ToListAsync(cancellationToken);

        if (!data.Any())
            return Result.Fail($"No records of {typeof(T)} is found!");

        return Result.Ok<IEnumerable<T>>(data);
    }

    public async Task<Result<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        var data = await _dbContext.Set<T>().AsNoTracking().ToListAsync(cancellationToken);

        if (!data.Any())
            return Result.Fail($"No records of {typeof(T)} is found!");

        return Result.Ok<IEnumerable<T>>(data);
    }


    public async Task<Result<T>> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken) {
    
        var data = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(expression, cancellationToken);

        if (data is null)
            return Result.Fail($"No record of {typeof(T)} is found!");

        return Result.Ok<T>(data);
    }

    public async Task<Result<bool>> GetAnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        var result = await _dbContext.Set<T>().AsNoTracking().AnyAsync(expression, cancellationToken);
        return Result.Ok<bool>(result);
    }

    public async Task<Result> UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);

        return Result.Ok();
    }
}
