using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public ServiceJogador()
        {
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var jogador = new Jogador
            {
                Email = request.Email,
                Senha = request.Senha,
                Status = Enum.EnumSituacaoJogador.Ativo
            };

            ValidarEmail(jogador.Email.Endereco);

            ValidarSenha(jogador.Senha);

            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse()
            {
                Id = id,
                Message = "Operação realizada com sucesso!"
            };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if(request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
                return null;
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            return response;
        }

        private void ValidarEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Informe o email para continuar.");
            }
        }

        private void ValidarSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                throw new Exception("Informe a senha para continuar.");
            }

            if (senha.Length <= 6)
            {
                throw new Exception("A senha deve ter mínimo 6 caracteres.");
            }
        }
    }
}
