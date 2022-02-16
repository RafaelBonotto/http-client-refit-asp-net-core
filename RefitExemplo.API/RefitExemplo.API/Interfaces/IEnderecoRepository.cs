using Refit;
using RefitExemplo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitExemplo.API.Interfaces
{
    public interface IEnderecoRepository
    {
        [Get("/v1/endereco/{cep}")]
        Task<EnderecoModel> ReturnEndereco(string cep);
    }
}
