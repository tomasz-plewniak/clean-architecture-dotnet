using Microsoft.AspNetCore.Mvc;

namespace SampleToDo.WebApi.Controllers;

public class ContributorsController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Create()
    {
        return Ok();
    }
    
    [HttpDelete("{contributorId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(long contributorId)
    {
        return Ok();
    }

    
    [HttpGet("{contributorId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(long contributorId)
    {
        return Ok();
    }
    
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> List()
    {
        return Ok();
    }
    
    [HttpPatch("{contributorId:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Update(long contributorId)
    {
        return Ok();
    }
}
