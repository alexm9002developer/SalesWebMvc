using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Servicos;

namespace SalesWebMvc.Controllers
{
    public class RegistroDeVendasController : Controller
    {
        private readonly RegistroDeVendasServicos _registroDeVendasServicos;

        public RegistroDeVendasController(RegistroDeVendasServicos registroDeVendasServicos)
        {
            _registroDeVendasServicos = registroDeVendasServicos;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> BuscaSimples(DateTime? dataInicial, DateTime? dataFinal)
        {
            if (!dataInicial.HasValue)
            {
                dataInicial = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!dataFinal.HasValue)
            {
                dataFinal = DateTime.Now;
            }
            ViewData["dataInicial"] = dataInicial.Value.ToString("yyyy-MM-dd");
            ViewData["dataFinal"] = dataFinal.Value.ToString("yyyy-MM-dd");
            var resultado = await _registroDeVendasServicos.FindByDateAsync(dataInicial, dataFinal);
            return View(resultado);
        }
        public async Task<IActionResult> BuscaAgrupada(DateTime? dataInicial, DateTime? dataFinal)
        {
            if (!dataInicial.HasValue)
            {
                dataInicial = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!dataFinal.HasValue)
            {
                dataFinal = DateTime.Now;
            }
            ViewData["dataInicial"] = dataInicial.Value.ToString("yyyy-MM-dd");
            ViewData["dataFinal"] = dataFinal.Value.ToString("yyyy-MM-dd");
            var resultado = await _registroDeVendasServicos.FindByDateGroupingAsync(dataInicial, dataFinal);
            return View(resultado);
        }
    }
}
