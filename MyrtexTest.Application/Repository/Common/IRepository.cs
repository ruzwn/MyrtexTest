using MyrtexTest.Domain.Model;
using MyrtexTest.Domain.Model.Common;

namespace MyrtexTest.Application.Repository.Common;

public interface IRepository<TEntity> where TEntity : BaseDomainModel
{
    Task<TEntity> GetOneAsync(Guid id, CancellationToken cancellationToken);

    Task<IList<TEntity>> GetManyAsync(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken);

    Task AddAsync(TEntity entity, CancellationToken cancellationToken);

    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken); // todo: не нужен ???

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
