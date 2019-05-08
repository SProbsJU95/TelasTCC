using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasTCC.DB.Base;

namespace TelasTCC.DB.Cliente
{
    class ClienteDatabase
    {
        public int Salvar(ClienteDTO dto)
        {
            string script = @"insert into tb_cliente (nm_cliente, tel_cliente_um, tel_cliente_dois, num_residencia_cliente, referencia_cliente, complemento_cliente) values (@nm_cliente, @tel_cliente_um, @tel_cliente_dois, @num_residencia_cliente, @referencia_cliente, @complemento_cliente)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            parms.Add(new MySqlParameter("tel_cliente_um", dto.tel_cliente_um));
            parms.Add(new MySqlParameter("tel_cliente_dois", dto.tel_cliente_dois));
            parms.Add(new MySqlParameter("num_residencia_cliente", dto.num_residencia));
            parms.Add(new MySqlParameter("referencia_cliente", dto.referencia));
            parms.Add(new MySqlParameter("complemento_cliente", dto.complemento));

            Database db = new Database();
            return db.ExecuteInsetScriptWithPk(script, parms);
        }

        public List<ClienteDTO> Listar()
        {
            string script = "select * from tb_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> lista = new List<ClienteDTO>();

            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.tel_cliente_um = reader.GetString("tel_cliente_um");
                //dto.tel_cliente_dois = reader.GetString("tel_cliente_dois");
                dto.num_residencia = reader.GetString("num_residencia_cliente");
                dto.referencia = reader.GetString("referencia_cliente");
                dto.complemento = reader.GetString("complemento_cliente");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
