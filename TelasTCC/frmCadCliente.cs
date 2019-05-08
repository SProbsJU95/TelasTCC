using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasTCC.DB.Cliente;

namespace TelasTCC
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nome = txtNome.Text;
            dto.tel_cliente_um = txtTelefone.Text;
            dto.num_residencia = txtNumero.Text;
            dto.referencia = txtTelefone.Text;
            dto.complemento = txtComplemento.Text;
            dto.referencia = txtReferencia.Text;

            ClienteBusiness business = new ClienteBusiness();
            business.Salvar(dto);

            MessageBox.Show("O cliente for cadastrado com sucesso.");
        }
    }
}
