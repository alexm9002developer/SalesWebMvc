using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório!")] // Informa para o sistema que o campo é obrigatório com mensagem para o usuário.
        // Informa para o sistema que o campo é obrigatório sem mensagem "[Required]"
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do Nome deve ser entre 3 e 60 caracteres")]
        // Informa o tamanho máximo e mínimo para um determinado campo.
        public string Nome { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [Required(ErrorMessage = "Informe o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a data de Nascimento!")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        public DateTime DataCadastroVendedor { get; set; }

        [Required(ErrorMessage = "Informe o Salário Base!")]
        [Range(1212.0, 50000.0, ErrorMessage = "{0} precisa ser entre {1} e {2}")]
        // {1} e {2} são números de referência para a mensagem - {0} É o nome do campo.
        [Display (Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        [Display (Name = "Departamento")] // para mudar o nome do Campo na visualização da tela
        // acrescentar a linha: "using System.ComponentModel.DataAnnotations;" no início do código.
        public Departamentos Departamentos { get; set; }
        public int DepartamentosId { get; set; }
        public ICollection<Vendas> VendaVendedor { get; set; } = new List<Vendas>();
        public Vendedor()
        {
        }
        public Vendedor(int id, string nome, string email, DateTime dataDeNascimento, int idade, DateTime dataCadastroVendedor, double salarioBase, Departamentos departamentos)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.DataDeNascimento = dataDeNascimento;
            this.Idade = idade;
            this.DataCadastroVendedor = dataCadastroVendedor;
            this.SalarioBase = salarioBase;
            this.Departamentos = departamentos;
        }
        public void AddVendaVendedor(Vendas vd)
        {
            VendaVendedor.Add(vd);
        }
        public void RemoveVendaVendedor(Vendas vd)
        {
            VendaVendedor.Remove(vd);
        }
        public double TotalDeVendas(DateTime inicial, DateTime final)
        {
            return VendaVendedor.Where(vd => vd.DataDaVenda >= inicial && vd.DataDaVenda <= final).Sum(vd => vd.ValorDaVenda);
        }
        public int CalculaIdade(DateTime dataDeNascimento)
        {
            int IdadeCalculada = DateTime.Now.Year - dataDeNascimento.Year;
            if (DateTime.Now.DayOfYear <= dataDeNascimento.DayOfYear)
            {
                IdadeCalculada = IdadeCalculada - 1;
                //outra forma de fazer decremento.
                //IdadeCalculada--;
            }
            return IdadeCalculada;
            // outra forma de fazer - if implícito.
            //return (DateTime.Now.DayOfYear < dataDeNascimento.DayOfYear) ? IdadeCalculada-- : IdadeCalculada;
        }
    }
}
