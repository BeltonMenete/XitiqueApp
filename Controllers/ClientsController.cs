using System.Net;
using XitiqueAPI.Data;
using Microsoft.AspNetCore.Mvc;
using XitiqueAPI.Models;
using AutoMapper;
using XitiqueAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace XitiqueAPI.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientsController(AppDbContext context, IMapper mapper, APIResponse apiResponse) : ControllerBase
{
    private readonly AppDbContext _context = context;
    private readonly IMapper _mapper = mapper;
    private readonly APIResponse _response = apiResponse;

    [HttpGet(Name = "GetClients")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<APIResponse>> GetClients()
    {
        _response.ResultData = await _context.Clients.ToListAsync();
        return Ok(_response);
    }

    [HttpPost(Name = "AddNewClient")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<APIResponse>> AddNewClient([FromBody] CreateClientDTO newClientDTO)
    {
        try
        {
            var newClient = _mapper.Map<Client>(newClientDTO);
            await _context.Clients.AddAsync(newClient);
            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.Created;
            _response.ResultData = newClient;
            return Ok(_response);
        }
        catch (Exception error)
        {
            _response.ErrorMessages = [error.Message.ToString()];
            return _response;
        }
    }
}
