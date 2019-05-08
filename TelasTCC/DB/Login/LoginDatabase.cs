using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasTCC.DB.Base;

namespace TelasTCC.DB.Login
{
    class LoginDatabase
    { 
        public List<LoginDTO> Pesquisar()
        {
            string script = "select id_usu, usuario_usu, senha_usu from tb_usuario WHERE usuario_usu =";
            script += " '" + "rob" + "' ";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<LoginDTO> lista = new List<LoginDTO>();

            LoginDTO dto = new LoginDTO();

            reader.Read();
            
            dto.Id = reader.GetInt32("id_usu");
            dto.Usuario = reader.GetString("usuario_usu");
            dto.Senha = reader.GetString("senha_usu");

            lista.Add(dto);
            
            reader.Close();

            return lista;
        }
    }
}
