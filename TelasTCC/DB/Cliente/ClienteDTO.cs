using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Cliente
{
    class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string tel_cliente_um { get; set; }
        public string tel_cliente_dois { get; set; }
        public string num_residencia { get; set; }
        public string referencia { get; set; }
        public string complemento { get; set; }
    }
}
