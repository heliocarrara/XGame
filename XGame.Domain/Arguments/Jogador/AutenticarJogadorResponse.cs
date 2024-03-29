﻿using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public string Email { get; set; }

        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador entidade)
        {
            return new AutenticarJogadorResponse
            {
                Id = entidade.Id,
                Email = entidade.Email?.Endereco,
                PrimeiroNome = entidade.Nome?.PrimeiroNome,
                Status = (int)entidade.Status
            };
        }
    }
}
