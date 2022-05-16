using System;

namespace SalesWebMvc.Servicos.Excecoes
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string mensagem) : base(mensagem)
        {
        }
    }
}
