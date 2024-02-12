using System;
using System.Collections.Generic;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories.Base;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador : IRepositoryBase<Jogador, Guid>
    {
        //Jogador AutenticarJogador(string email, string senha);

        //Jogador AdicionarJogador(Jogador jogador);

        //IEnumerable<Jogador> ListarJogador();

        //Jogador ObterJogadorPorId(Guid id);

        //Jogador AlterarJogador(Jogador jogador);
    }
}
