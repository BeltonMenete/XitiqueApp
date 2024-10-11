using XitiqueAPI.Data;
using Microsoft.AspNetCore.Mvc;
using XitiqueAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AutoMapper;

namespace XitiqueAPI.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientsController(AppDbContext context, IMapper mapper) : ControllerBase
{
    private readonly AppDbContext _context = context;
    private readonly IMapper _mapper = mapper;

    [HttpGet(Name = "GetClients")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult GetClients()
    {
        var response = _context.Clients.ToList();
        return Ok(response);
    }

    [HttpPost(Name = "AddNewClient")]
    public async ActionResult AddNewClient([FromBody] CreateClientDto newClient)
    {
        var client = _mapper.Map<Client>(newClient);
        await _context.AddAsync();
        return Ok();
    }
}
