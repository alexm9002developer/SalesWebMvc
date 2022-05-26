using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departamentos.Any() ||
                _context.Vendedor.Any() ||
                _context.Vendas.Any())
            {
                return; //Banco de dados já foi populado.
            }
            Departamentos d1 = new Departamentos(1, "Salão", new DateTime(2022, 1, 2));
            Departamentos d2 = new Departamentos(2, "Cozinha", new DateTime(2022, 1, 2));
            Departamentos d3 = new Departamentos(3, "Copa", new DateTime(2022, 1, 2));
            Departamentos d4 = new Departamentos(4, "Sushi", new DateTime(2022, 1, 2));
            Departamentos d5 = new Departamentos(5, "Administrativo", new DateTime(2022, 1, 2));
            Departamentos d6 = new Departamentos(6, "Limpeza", new DateTime(2022, 1, 2));
            Departamentos d7 = new Departamentos(7, "Estoque", new DateTime(2022, 1, 2));
            Departamentos d8 = new Departamentos(8, "Delivery", new DateTime(2022, 1, 2));
            //Departamentos d8 = new Departamentos { Id = 8, Nome = "Estoque" }; //Outra forma de fazer.

            Vendedor v1 = new Vendedor(1, "Bruno", "bruno@gmail.com", new DateTime(1998, 4, 21), new DateTime(2022, 1, 2), 1400.0, d1);
            Vendedor v2 = new Vendedor(2, "Fernando", "fernando@gmail.com", new DateTime(1997, 3, 20), new DateTime(2022, 1, 2), 1400.0, d8);
            Vendedor v3 = new Vendedor(3, "Leandro", "leandro@gmail.com", new DateTime(1996, 2, 19), new DateTime(2022, 1, 2), 1400.0, d1);
            Vendedor v4 = new Vendedor(4, "Tiago", "tiago@gmail.com", new DateTime(1999, 6, 18), new DateTime(2022, 1, 2), 1400.0, d1);
            Vendedor v5 = new Vendedor(5, "Lucas", "lucas@gmail.com", new DateTime(2000, 1, 17), new DateTime(2022, 1, 2), 1400.0, d8);
            Vendedor v6 = new Vendedor(6, "Virginio", "virginio@gmail.com", new DateTime(1970, 7, 25), new DateTime(2022, 1, 2), 1400.0, d4);
            Vendedor v7 = new Vendedor(7, "Josandro", "josandro@gmail.com", new DateTime(1995, 8, 28), new DateTime(2022, 1, 2), 1400.0, d8);
            Vendedor v8 = new Vendedor(8, "Jorge", "jorge@gmail.com", new DateTime(1976, 9, 29), new DateTime(2022, 1, 2), 1400.0, d4);
            Vendedor v9 = new Vendedor(9, "Nilo", "nilo@gmail.com", new DateTime(1984, 5, 12), new DateTime(2022, 1, 2), 1400.0, d8);

            Vendas rv1 = new Vendas(1, new DateTime(2022, 01, 25), 11000.0, VendaStatus.Faturado, v1);
            Vendas rv2 = new Vendas(2, new DateTime(2022, 01, 4), 7000.0, VendaStatus.Faturado, v5);
            Vendas rv3 = new Vendas(3, new DateTime(2022, 01, 13), 4000.0, VendaStatus.Cancelado, v8);
            Vendas rv4 = new Vendas(4, new DateTime(2022, 01, 1), 8000.0, VendaStatus.Faturado, v1);
            Vendas rv5 = new Vendas(5, new DateTime(2022, 01, 21), 3000.0, VendaStatus.Faturado, v3);
            Vendas rv6 = new Vendas(6, new DateTime(2022, 01, 15), 2000.0, VendaStatus.Faturado, v1);
            Vendas rv7 = new Vendas(7, new DateTime(2022, 02, 28), 13000.0, VendaStatus.Faturado, v2);
            Vendas rv8 = new Vendas(8, new DateTime(2022, 02, 11), 4000.0, VendaStatus.Faturado, v4);
            Vendas rv9 = new Vendas(9, new DateTime(2022, 02, 14), 11000.0, VendaStatus.Pendente, v6);
            Vendas rv10 = new Vendas(10, new DateTime(2022, 03, 7), 9000.0, VendaStatus.Faturado, v6);
            Vendas rv11 = new Vendas(11, new DateTime(2022, 03, 13), 6000.0, VendaStatus.Faturado, v2);
            Vendas rv12 = new Vendas(12, new DateTime(2022, 03, 25), 7000.0, VendaStatus.Pendente, v7);
            Vendas rv13 = new Vendas(13, new DateTime(2022, 04, 29), 10000.0, VendaStatus.Faturado, v4);
            Vendas rv14 = new Vendas(14, new DateTime(2022, 04, 4), 3000.0, VendaStatus.Faturado, v5);
            Vendas rv15 = new Vendas(15, new DateTime(2022, 04, 12), 4000.0, VendaStatus.Faturado, v1);
            Vendas rv16 = new Vendas(16, new DateTime(2022, 05, 5), 2000.0, VendaStatus.Faturado, v4);
            Vendas rv17 = new Vendas(17, new DateTime(2022, 05, 1), 12000.0, VendaStatus.Faturado, v1);
            Vendas rv18 = new Vendas(18, new DateTime(2022, 05, 24), 6000.0, VendaStatus.Faturado, v3);
            Vendas rv19 = new Vendas(19, new DateTime(2022, 05, 22), 8000.0, VendaStatus.Faturado, v7);
            Vendas rv20 = new Vendas(20, new DateTime(2022, 05, 15), 8000.0, VendaStatus.Faturado, v6);
            Vendas rv21 = new Vendas(21, new DateTime(2022, 05, 17), 9000.0, VendaStatus.Faturado, v2);
            Vendas rv22 = new Vendas(22, new DateTime(2022, 06, 24), 4000.0, VendaStatus.Faturado, v8);
            Vendas rv23 = new Vendas(23, new DateTime(2022, 06, 19), 11000.0, VendaStatus.Cancelado, v9);
            Vendas rv24 = new Vendas(24, new DateTime(2022, 06, 12), 8000.0, VendaStatus.Faturado, v5);
            Vendas rv25 = new Vendas(25, new DateTime(2022, 06, 30), 7000.0, VendaStatus.Faturado, v3);
            Vendas rv26 = new Vendas(26, new DateTime(2022, 06, 6), 5000.0, VendaStatus.Faturado, v4);
            Vendas rv27 = new Vendas(27, new DateTime(2022, 06, 13), 9000.0, VendaStatus.Pendente, v1);
            Vendas rv28 = new Vendas(28, new DateTime(2022, 06, 7), 4000.0, VendaStatus.Faturado, v3);
            Vendas rv29 = new Vendas(29, new DateTime(2022, 07, 23), 12000.0, VendaStatus.Faturado, v9);
            Vendas rv30 = new Vendas(30, new DateTime(2022, 07, 12), 5000.0, VendaStatus.Faturado, v2);
            Vendas rv31 = new Vendas(31, new DateTime(2022, 08, 25), 2500.0, VendaStatus.Faturado, v1);
            Vendas rv32 = new Vendas(32, new DateTime(2022, 08, 4), 7000.0, VendaStatus.Faturado, v5);
            Vendas rv33 = new Vendas(33, new DateTime(2022, 08, 13), 4000.0, VendaStatus.Cancelado, v8);
            Vendas rv34 = new Vendas(34, new DateTime(2022, 08, 1), 8000.0, VendaStatus.Faturado, v1);
            Vendas rv35 = new Vendas(35, new DateTime(2022, 08, 21), 3000.0, VendaStatus.Faturado, v3);
            Vendas rv36 = new Vendas(36, new DateTime(2022, 08, 15), 2000.0, VendaStatus.Pendente, v1);
            Vendas rv37 = new Vendas(37, new DateTime(2022, 09, 28), 13000.0, VendaStatus.Faturado, v2);
            Vendas rv38 = new Vendas(38, new DateTime(2022, 09, 11), 4000.0, VendaStatus.Faturado, v4);
            Vendas rv39 = new Vendas(39, new DateTime(2022, 09, 14), 1600.0, VendaStatus.Pendente, v6);
            Vendas rv40 = new Vendas(40, new DateTime(2022, 10, 7), 9000.0, VendaStatus.Faturado, v6);
            Vendas rv41 = new Vendas(41, new DateTime(2022, 10, 13), 6000.0, VendaStatus.Faturado, v2);
            Vendas rv42 = new Vendas(42, new DateTime(2022, 10, 25), 7000.0, VendaStatus.Pendente, v7);
            Vendas rv43 = new Vendas(43, new DateTime(2022, 10, 29), 10000.0, VendaStatus.Faturado, v4);
            Vendas rv44 = new Vendas(44, new DateTime(2022, 10, 4), 3000.0, VendaStatus.Cancelado, v5);
            Vendas rv45 = new Vendas(45, new DateTime(2022, 10, 12), 4000.0, VendaStatus.Faturado, v1);
            Vendas rv46 = new Vendas(46, new DateTime(2022, 11, 5), 2000.0, VendaStatus.Faturado, v4);
            Vendas rv47 = new Vendas(47, new DateTime(2022, 11, 1), 12000.0, VendaStatus.Faturado, v1);
            Vendas rv48 = new Vendas(48, new DateTime(2022, 11, 24), 6000.0, VendaStatus.Faturado, v3);
            Vendas rv49 = new Vendas(49, new DateTime(2022, 11, 22), 1500.0, VendaStatus.Pendente, v7);
            Vendas rv50 = new Vendas(50, new DateTime(2022, 11, 15), 8000.0, VendaStatus.Faturado, v6);
            Vendas rv51 = new Vendas(51, new DateTime(2022, 11, 17), 9000.0, VendaStatus.Faturado, v2);
            Vendas rv52 = new Vendas(52, new DateTime(2022, 12, 24), 4000.0, VendaStatus.Faturado, v8);
            Vendas rv53 = new Vendas(53, new DateTime(2022, 12, 19), 1100.0, VendaStatus.Cancelado, v9);
            Vendas rv54 = new Vendas(54, new DateTime(2022, 12, 12), 8000.0, VendaStatus.Faturado, v5);
            Vendas rv55 = new Vendas(55, new DateTime(2022, 12, 30), 7000.0, VendaStatus.Faturado, v3);
            Vendas rv56 = new Vendas(56, new DateTime(2022, 12, 6), 5000.0, VendaStatus.Faturado, v4);
            Vendas rv57 = new Vendas(57, new DateTime(2022, 12, 13), 9000.0, VendaStatus.Pendente, v1);
            Vendas rv58 = new Vendas(58, new DateTime(2022, 12, 7), 4000.0, VendaStatus.Faturado, v3);
            Vendas rv59 = new Vendas(59, new DateTime(2022, 12, 23), 1200.0, VendaStatus.Faturado, v9);
            Vendas rv60 = new Vendas(60, new DateTime(2022, 12, 12), 5000.0, VendaStatus.Faturado, v2);


            _context.Departamentos.AddRange(d1, d2, d3, d4, d5, d6, d7);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9);
            _context.Vendas.AddRange(
                rv1, rv2, rv3, rv4, rv5, rv6, rv7, rv8, rv9, rv10,
                rv11, rv12, rv13, rv14, rv15, rv16, rv17, rv18, rv19, rv20,
                rv21, rv22, rv23, rv24, rv25, rv26, rv27, rv28, rv29, rv30,
                rv31, rv32, rv33, rv34, rv35, rv36, rv37, rv38, rv39, rv40,
                rv41, rv42, rv43, rv44, rv45, rv46, rv47, rv48, rv49, rv50,
                rv51, rv52, rv53, rv54, rv55, rv56, rv57, rv58, rv59, rv60
                );
            _context.SaveChanges();
        }

    }

}
