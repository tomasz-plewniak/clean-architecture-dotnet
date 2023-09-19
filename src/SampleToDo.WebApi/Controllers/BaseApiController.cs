using Microsoft.AspNetCore.Mvc;

namespace SampleToDo.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
}
