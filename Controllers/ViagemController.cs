using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIViagem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViagemController : ControllerBase
    {
     [HttpGet]
     public string TesteConexao()
     {
        return "API OK!";
     }   
    }
}