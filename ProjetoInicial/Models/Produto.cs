using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoInicial.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Campo obrigatório!")] public string Nome { get; set; }

        [Range(0, 9999999, ErrorMessage = "Informe a quantidade adequada!")]
        public int Quantidade { get; set; }

        [Range(0.1, 9999999, ErrorMessage = "Informe o preço adequado!")]
        public double Preco {  get; set; }

        public double ValorEstoqueTotal()
        {
            return Preco*Quantidade;
        }

    }
}
