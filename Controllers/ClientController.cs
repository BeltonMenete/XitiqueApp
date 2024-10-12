using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xitiqueAPI.Models;
using xitiqueAPI.Models.DTOs;
using XitiqueAPI.Data;


[ApiController]
[Route("api/client")]
public class ClientController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public ClientController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Get all clients
    [HttpGet(Name = "GetAllClients")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<Client>>> GetAllClients()
    {
        return Ok(await _context.Clients.ToListAsync());
    }

    // Get one client by Base64-encoded id
    [HttpGet("{id}", Name = "GetOneClient")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Client>> GetOneClient(Guid id)
    {
        try
        {
            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }
        catch (FormatException)
        {
            return BadRequest("Invalid ID format");
        }
    }

    // Create new client
    [HttpPost(Name = "CreateNewClient")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> CreateNewClient([FromBody] CreateClientDTO newClientDTO)
    {
        if (newClientDTO == null)
        {
            return BadRequest();
        }

        // Map DTO to Client
        var newClient = _mapper.Map<Client>(newClientDTO);
        newClient.CreationDate = DateTime.UtcNow.Date;
        await _context.Clients.AddAsync(newClient);
        await _context.SaveChangesAsync();

        return CreatedAtRoute("GetOneClient", new { id = newClient.Id }, newClient);
    }
}