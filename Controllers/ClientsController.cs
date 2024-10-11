using XitiqueAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace XitiqueAPI.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientsController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;


    [HttpGet(Name = "GetClients")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult GetClients()
    {
        var response = _context.Clients.ToList();
        return Ok(response);
    }
}
