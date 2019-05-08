using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Usuario
{
    class UsuarioBusiness
    {
        public int Salvar(UsuarioDTO dto)
        {
            if (dto.Nome == string.Empty)
                throw new ArgumentException("Nome é obrigatório.");

            if (dto.Usuario == string.Empty)
                throw new ArgumentException("Usuário é obrigatório.");

            if (dto.Senha == string.Empty)
                throw new ArgumentException("Senha é obrigatória.");

            if (dto.ConfirmarSenha == string.Empty)
                throw new ArgumentException("Confirmação de senha é obrigatória.");

            if (dto.Celular == string.Empty)
                throw new ArgumentException("Celular é obrigatório.");

            if (dto.CPF == string.Empty)
                throw new ArgumentException("CPF é obrigatório.");

            if (dto.Salario == string.Empty)
                throw new ArgumentException("Salário é obrigatório.");

            if (dto.Funcao == string.Empty)
                throw new ArgumentException("Função do funcionário é obrigatória.");

            UsuarioDatabase db = new UsuarioDatabase();
            return db.Salvar(dto);
        }

        public List<UsuarioDTO> Listar()
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Listar();
        }
    }
}
