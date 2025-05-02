using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Serves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static Server server;
        static void Init() {
            server = new Server();

            server.RegisterUSer("joaorogodoy@gmail.com", "123");

            server.RegisterUSer("k1godoy@gmail.com", "123");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());            

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args) {

            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail: "); 
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua Senha: ");
                string password = Console.ReadLine();

                done = server.Login(email, password);

            } while (!done);

            Console.ReadLine();
        }
    }
}
