using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasTCC.DB.Base;

namespace TelasTCC.DB.FinalizarCompra
{
    class FinalizarCompraDatabase
    {
        public int Salvar(FinalizarCompraDTO dto)
        {
            string script = @"insert into tb_cliente (nm_cliente, tel_cliente_um, tel_cliente_dois, num_residencia_cliente, referencia_cliente, complemento_cliente) values (@nm_cliente, @tel_cliente_um, @tel_cliente_dois, @num_residencia_cliente, @referencia_cliente, @complemento_cliente)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            

            Database db = new Database();
            return db.ExecuteInsetScriptWithPk(script, parms);
        }

        public static void FinalizarCompra()
        {
            FinalizarCompraDTO user = new FinalizarCompraDTO();

        }

        public List<FinalizarCompraDTO> Listar()
        {
            string script = "select * from tb_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FinalizarCompraDTO> lista = new List<FinalizarCompraDTO>();

            while (reader.Read())
            {
                FinalizarCompraDTO dto = new FinalizarCompraDTO();
                dto.Id = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.Celular = reader.GetString("tel_cliente_um");
                //dto.Funcao = reader.GetString("tel_cliente_dois");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
