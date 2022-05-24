using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        [Display (Name = "Departamento")]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
        public Departamentos()
        {
        }
        public Departamentos(int id, string nome, DateTime dataCadastro)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataCadastro = dataCadastro;
            dataCadastro = DateTime.Now;
        }
        public void AddVendedor(Vendedor vendedor)
        {

            Vendedores.Add(vendedor);
        }
        public double TotalDeVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalDeVendas(inicial, final));
        }
    }
}
