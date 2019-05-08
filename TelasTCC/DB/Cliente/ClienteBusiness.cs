using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Cliente
{
    class ClienteBusiness
    {
        public int Salvar(ClienteDTO dto)
        {
            if (dto.Nome == string.Empty)
                throw new ArgumentException("Nome é obrigatório.");

            if (dto.tel_cliente_um == string.Empty)
                throw new ArgumentException("Telefone é obrigatório.");

            if (dto.num_residencia == string.Empty)
                throw new ArgumentException("Número da residencia é obrigatório.");
            
            ClienteDatabase db = new ClienteDatabase();
            return db.Salvar(dto);
        }

        public List<ClienteDTO> Listar()
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.Listar();
        }
    }
}
