using System;

namespace ChainOfResponsability.Middlewares
{
    abstract class Middleware {

        private Middleware next;

        public Middleware LinkWith(Middleware next) {

            this.next = next;
            return next;
        }

        public abstract Boolean Check(string email, string password);

        protected Boolean CheckNext(string email, string password) {

            if (email == null) { return true; }

            return Check(email, password);
        }
    }
}
