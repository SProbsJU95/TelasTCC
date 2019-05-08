using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Usuario
{
    class UsuarioDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string  ConfirmarSenha { get; set; }

        public string Celular { get; set; }

        public string CPF { get; set; }

        public string Salario { get; set; }

        public string Funcao { get; set; }
    }
}
