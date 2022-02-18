using Microsoft.AspNetCore.Mvc;
using RefitExemplo.API.Interfaces;
using RefitExemplo.API.Models;
using System.Threading.Tasks;

namespace RefitExemplo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        [HttpGet]        
        public async Task<EnderecoModel> GetEndereco([FromServices] IEnderecoRepository repository, [FromQuery] string cep)
        {
            return await repository.ReturnEndereco(cep);
        }
    }
}
