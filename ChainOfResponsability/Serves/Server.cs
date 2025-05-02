using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Serves
{
    class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware) {

            this.middleware = middleware;
        }

        public Boolean Login(string email, string password) {

            if (middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso");
                Console.WriteLine("Seja bem-vindo!");
                Console.ReadLine();
                return true;
            }
            return false;
        }

        public void RegisterUSer(string email, string password) {

            _users[email] = password;
        }

        public Boolean HasEmail(string email) {

            return _users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password) {

            string value = string.Empty;

            _users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
