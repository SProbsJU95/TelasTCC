using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasTCC.DB.Base;

namespace TelasTCC.DB.Usuario
{
    class UsuarioDatabase
    {
        public int Salvar(UsuarioDTO dto)
        {
            string script = @"insert into tb_usuario (nm_usu, usuario_usu, senha_usu, cel_usu, cpf_usu, salario_usu, funcao_usu) values (@nm_usu, @usuario_usu, @senha_usu, @cel_usu, @cpf_usu, @salario_usu, @funcao_usu)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_usu", dto.Nome));
            parms.Add(new MySqlParameter("usuario_usu", dto.Usuario));
            parms.Add(new MySqlParameter("senha_usu", dto.Senha));
            parms.Add(new MySqlParameter("cel_usu", dto.Celular));
            parms.Add(new MySqlParameter("cpf_usu", dto.CPF));
            parms.Add(new MySqlParameter("salario_usu", dto.Salario));
            parms.Add(new MySqlParameter("funcao_usu", dto.Funcao));

            Database db = new Database();
            return db.ExecuteInsetScriptWithPk(script, parms);
        }

        public List<UsuarioDTO> Listar()
        {
            string script = "select * from tb_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();

            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Id      = reader.GetInt32("id_usu");
                dto.Nome    = reader.GetString("nm_usu");
                dto.Usuario = reader.GetString("usuario_usu");
                dto.Senha   = reader.GetString("senha_usu");
                dto.Celular = reader.GetString("cel_usu");
                dto.CPF     = reader.GetString("cpf_usu");
                dto.Salario = reader.GetString("salario_usu");
                dto.Funcao  = reader.GetString("funcao_usu");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
