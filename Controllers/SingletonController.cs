using Microsoft.AspNetCore.Mvc;

namespace PatronesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SingletonController: ControllerBase
{
    private readonly ILogger<SingletonController> _logger;

    public SingletonController(ILogger<SingletonController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetInstanceName")]
    public string GetInstanceName(){



    }




}