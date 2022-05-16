using System;
using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Vendas
    {
        public int Id { get; set; }

        [Display(Name = "Data da Venda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDaVenda { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Valor da Venda")]
        public double ValorDaVenda { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public Vendas()
        {
        }
        public Vendas(int id, DateTime dataDaVenda, double valorDaVenda, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            DataDaVenda = dataDaVenda;
            ValorDaVenda = valorDaVenda;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
