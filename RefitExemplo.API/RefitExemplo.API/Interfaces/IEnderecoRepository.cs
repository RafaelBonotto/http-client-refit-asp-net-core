﻿using Microsoft.AspNetCore.Mvc;
using Refit;
using RefitExemplo.API.Models;
using System.Threading.Tasks;

namespace RefitExemplo.API.Interfaces
{
    public interface IEnderecoRepository
    {
        [Get("/ws/{cep}/json")]
        Task<EnderecoModel> ReturnEndereco(string cep);
    }
}
