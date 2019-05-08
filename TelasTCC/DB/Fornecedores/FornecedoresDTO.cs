using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Fornecedores
{
    class FornecedoresDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fornecimento { get; set; }
        public string TipoProduto { get; set; }
        public string Cnpj{ get; set; }
        public string Telefone_um { get; set; }
        public string Telefone_dois { get; set; }
    }
}
