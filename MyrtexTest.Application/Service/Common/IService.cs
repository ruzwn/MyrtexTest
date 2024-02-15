namespace MyrtexTest.Application.Service.Common;

public interface IService<in TRequest, TResponse> // todo: зачем тут модификатор in ???
{
    Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}
