using Microsoft.AspNetCore.Mvc;

namespace MyrtexTest.Api.Controller;

[ApiController]
[Route("api/[controller]")] // todo: версионирование ???
public class BaseController : ControllerBase
{
    protected TService GetService<TService>() where TService : class // todo: можно ли сделать здесь TService : IService
    {
        // todo: RequestServices это фабрика ???
        // todo: GetRequiredService бросает ошибку если нет такого сервиса ???
        var service = HttpContext.RequestServices.GetRequiredService<TService>();

        return service;
    }
}
