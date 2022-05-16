using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Servicos
{
    public class RegistroDeVendasServicos
    {
        private readonly SalesWebMvcContext _context;
        public RegistroDeVendasServicos(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Vendas>> FindByDateAsync(DateTime? dataInicial, DateTime? dataFinal)
        {
            var resultado = from obj in _context.Vendas select obj;
            if (dataInicial.HasValue)
            {
                resultado = resultado.Where(x => x.DataDaVenda >= dataInicial.Value);
            }
            if (dataFinal.HasValue)
            {
                resultado = resultado.Where(x => x.DataDaVenda <= dataFinal.Value);
            }
            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamentos)
                .OrderByDescending(x => x.DataDaVenda)
                .ToListAsync();
        }
        public async Task<List<IGrouping<Departamentos,Vendas>>> FindByDateGroupingAsync(DateTime? dataInicial, DateTime? dataFinal)
        {
            var resultado = from obj in _context.Vendas select obj;
            if (dataInicial.HasValue)
            {
                resultado = resultado.Where(x => x.DataDaVenda >= dataInicial.Value);
            }
            if (dataFinal.HasValue)
            {
                resultado = resultado.Where(x => x.DataDaVenda <= dataFinal.Value);
            }
            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamentos)
                .OrderByDescending(x => x.DataDaVenda)
                .GroupBy(x => x.Vendedor.Departamentos)
                .ToListAsync();
        }
    }
}
