using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIQUEGOMES_3A1_08.Code.DTO
{
    class ProdutosDTO
    {
        private int _id;
        private string _produto;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
