using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Servicos
{
    public class DepartamentosServicos
    {
        private readonly SalesWebMvcContext _context;
        public DepartamentosServicos(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Departamentos>> FindAllAsync()
        {
            return await _context.Departamentos.OrderBy(y => y.Nome).ToListAsync(); //OrderBy => Para colocar em ordem de nome
        }   // Para usar operações assíncronas precisamos usar "await", "Task", "async",
            // "using Microsoft.EntityFrameworkCore;" e "using System.Threading.Tasks;"
    }       // Usamos operações Assícronas para aplicação não ficar travada aguardando a execução do comando.
}           // Ex.: Acessar o banco de dados. 
