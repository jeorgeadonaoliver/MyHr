

namespace myHr.application.Contracts
{
    public interface IGenericRepository <T> 
        where T : class
    {
        public Task<Result<T>> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);

        public Task<Result<IEnumerable<T>>> GetAllAsync(CancellationToken cancellationToken);

        public Task<Result<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);

        public Task<Result> CreateAsync(T entity, CancellationToken cancellationToken);

        public Task<Result> UpdateAsync(T entity, CancellationToken cancellationToken);

        public Task<Result> DeleteAsync(T entity, CancellationToken cancellationToken);

        public Task<Result<bool>> GetAnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
    }
}
