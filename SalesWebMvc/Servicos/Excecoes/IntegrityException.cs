using System;

namespace SalesWebMvc.Servicos.Excecoes
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string mensagem) : base(mensagem)
        {
        }
    }
}
