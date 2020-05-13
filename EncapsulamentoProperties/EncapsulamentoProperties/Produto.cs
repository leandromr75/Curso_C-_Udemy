using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProperties
{
    class Produto
    {
        private string _descricao;
        private int _qtde;
        public int Qtde { get; private set; }
        public Produto(string d, int q)
        {
            _descricao = d;
            _qtde = q;
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        /*public double Qtde
        {
            get { return _qtde;}
        }*/
        public override string ToString()
        {
            return "Tipo: " + _descricao + "\nQuantidade: " + _qtde;
        }
    }
}
