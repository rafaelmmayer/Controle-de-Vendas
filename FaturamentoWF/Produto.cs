using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoWF
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, string tipo, int id)
        {
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
            ID = id;
        }
    }
}
