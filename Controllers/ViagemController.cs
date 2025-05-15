using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIViagem.Models; // Aqui estou importando todos os arquivos da pasta Models.
using APIViagem.Services; // Importando a pasta Services. 

namespace APIViagem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViagemController : ControllerBase
    {
        private readonly IAService _iaService; // Crio uma variavel privada chamada _iaService que vem lá do meu arquivo IAService

        public ViagemController()
        {
            _iaService = new IAService(); // Instancia da classe para poder usar os metodos do controller
        }

        [HttpGet]
        public string TesteConexao()
        {
            return "API OK!"; // Mensagem de teste para saber se a API está funcionando
        }

        [HttpPost("calcular-rota")]
        public IActionResult CalcularRota([FromBody] DadosViagem dados)
        {
            var resultado = _iaService.ObterResultadoDaIA(dados); // Chama o método do serviço passando os dados da viagem
            return Ok(resultado); // Retorna o resultado da IA como resposta
        }
    }
}
