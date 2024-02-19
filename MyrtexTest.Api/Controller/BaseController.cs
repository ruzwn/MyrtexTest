using Microsoft.AspNetCore.Mvc;

namespace MyrtexTest.Api.Controller;

// todo: версионирование ???
// todo: нужно ли добавлять api или это сделает apicontroller ???
// todo: нужен ли тут [action], т.к. это api ???
[ApiController]
[Route("api/[controller]/[action]")]
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
