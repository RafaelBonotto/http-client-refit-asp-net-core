using Microsoft.AspNetCore.Mvc;
using Refit;
using RefitExemplo.API.Interfaces;
using RefitExemplo.API.Models;
using System.Threading.Tasks;

namespace RefitExemplo.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        [HttpGet("exemplo1")]        
        public async Task<EnderecoModel> GetEnderecoExemplo1([FromServices] IEnderecoRepository repository, [FromQuery] string cep)
        {
            return await repository.ReturnEndereco(cep);
        }

        [HttpGet("exemplo2")]
        public async Task<EnderecoModel> GetEnderecoExemplo2([FromQuery] string cep)
        {
            var urlBase = "https://viacep.com.br";
            var api = RestService.For<IEnderecoRepository>(urlBase);
             
            return await api.ReturnEnderecoExemplo2(cep); 
        }
    }
}
