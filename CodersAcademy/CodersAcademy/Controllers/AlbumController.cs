﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodersAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlbuns()
        {
            return Ok(new
            {
                Message = "Primeira API Criada"
            });
        }
    }
}
