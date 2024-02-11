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

            Autenticar(service);
            Adicionar(service);

            var result = service.ListarJogador();

            Console.ReadKey();
        }

        private static void Autenticar(ServiceJogador service)
        {
            var request = new AutenticarJogadorRequest();
            Console.WriteLine("Agora criamos a instância do meu objeto request");

            request.Email = "Joao@gmail.com";
            request.Senha = "222333";

            var response = service.AutenticarJogador(request);

            if (service.IsInvalid())
            {
                foreach (var notification in service.Notifications)
                {
                    Console.WriteLine(notification.Message);
                }
            }
        }


        private static void Adicionar(ServiceJogador service)
        {
            var request = new AdicionarJogadorRequest()
            {
                PrimeiroNome = "Helio",
                UltimoNome = "Carrara",
                Email = "email@email.com",
                Senha = "123456"
            };

            Console.WriteLine("Agora criamos a instância do meu objeto request");

            var response = service.AdicionarJogador(request);

            if (service.IsInvalid())
            {
                foreach (var notification in service.Notifications)
                {
                    Console.WriteLine(notification.Message);
                }
            }
        }
    }
}
