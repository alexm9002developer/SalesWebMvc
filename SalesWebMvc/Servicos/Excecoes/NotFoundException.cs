using System;

namespace SalesWebMvc.Servicos.Excecoes
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string mensagem) : base(mensagem)
        {
        }
    }
}
