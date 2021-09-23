using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Model { 

    //Classe de Model do Produto
    public class ProdutoModel
    {
        public string Nome { get; set; }

        public string Valor { get; set; }
        public int id { get; set; }

        public string categoria { get; set; }
    }
}
