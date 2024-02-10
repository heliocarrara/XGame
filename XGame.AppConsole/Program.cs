using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criamos a instância do serviço...");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Agora criamos a instância do meu objeto request");

            request.Email = "Joao@gmail.com";
            request.Senha = "222333";

            var response = service.AutenticarJogador(request);

            if(service.IsInvalid())
            {
                foreach(var notification in service.Notifications)
                {
                    Console.WriteLine(notification.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
