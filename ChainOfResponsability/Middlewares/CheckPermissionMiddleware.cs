using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password) {
           if (email.Equals("joaorogodoy@gmail.com"))
            {
                Console.WriteLine("Seja bem bindo Adm");
                return true;
            }

            Console.WriteLine("Seja bem vindo!");

            return CheckNext(email, password);
        }
    }
}
