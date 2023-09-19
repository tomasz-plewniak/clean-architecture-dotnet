using Microsoft.AspNetCore.Mvc;

namespace SampleToDo.WebApi.Controllers;

public class ProjectsController : BaseApiController
{
    // Get: api/projects
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    // GET: api/projects
    [HttpGet("{projectId:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    // POST: api/projects
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post()
    {
        return Ok();
    }

    // PATCH: api/projects/{projectId}/complete/{itemId}
    [HttpPatch("{projectId:int}/complete/{itemId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Complete(int projectId, int itemId)
    {
        return Ok();
    }
}
