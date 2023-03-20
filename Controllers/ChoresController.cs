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


}