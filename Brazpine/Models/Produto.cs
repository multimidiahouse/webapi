using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brazpine.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Quantidade { get; set; }
        public TipoProduto Tipo { get; set; }
        public enum TipoProduto { Alimento = 1, Limpeza = 2, Eletrodomestico = 3, Outros = 4 }
    }
}
