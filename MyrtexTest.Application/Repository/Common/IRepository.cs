using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Repository.Common;

public interface IRepository<TEntity> where TEntity : BaseDomainModel
{
    Task<TEntity> GetOneAsync(Guid id, CancellationToken cancellationToken);

    Task<IList<TEntity>> GetManyAsync(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken);
}
