using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoresLab.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChoresLab.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }

    [HttpGet]

    public ActionResult<List<Chore>> GetAllChores()
    {
        try
        {
            return Ok(_choresService.GetAllChores());
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }

    }

    [HttpGet("{id}")]
    public ActionResult<Chore> GetOneChore(int id)
    {
        try
        {
            Chore chore = _choresService.GetOneChore(id);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}