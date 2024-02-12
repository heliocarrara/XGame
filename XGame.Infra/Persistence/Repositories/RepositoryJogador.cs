using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Infra.Persistence.Repositories.Base;

namespace XGame.Infra.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }

        //public Jogador AutenticarJogador(string email, string senha)
        //{
        //    throw new NotImplementedException();
        //}

        //public Jogador AdicionarJogador(Jogador jogador)
        //{
        //    _context.Jogadores.Add(jogador);

        //    _context.SaveChanges();

        //    return jogador;
        //}

        //public Jogador AlterarJogador(Jogador jogador)
        //{
        //    throw new NotImplementedException();
        //}
              

        //public IEnumerable<Jogador> ListarJogador()
        //{
        //    return _context.Jogadores.ToList();
        //}

        //public Jogador ObterJogadorPorId(Guid id)
        //{
        //    return _context.Jogadores.Find(id);
        //}

        //public int CalcularJogadores()
        //{
        //    var nome = "";
        //    var ultimoNome = "";
        //    var email = "";

        //    var jogadores = _context.Jogadores.AsNoTracking().AsQueryable();

        //    if(!string.IsNullOrEmpty(nome))
        //    {
        //        jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(nome));
        //    }

        //    if(!string.IsNullOrEmpty(ultimoNome))
        //    {
        //        jogadores.Where(x => x.Nome.UltimoNome.StartsWith(ultimoNome));
        //    }

        //    if (!string.IsNullOrEmpty(email))
        //    {
        //        jogadores.Where(x => x.Email.Endereco == email);
        //    }

        //    return jogadores.AsParallel().ToList().Count();
        //}
    }
}
