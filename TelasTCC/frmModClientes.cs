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
    public partial class frmModClientes : Form
    {
        public frmModClientes()
        {
            InitializeComponent();
        }

        
        
        private void btnClientesCadastrados_Click_1(object sender, EventArgs e)
        {
            ClienteBusiness business = new ClienteBusiness();
            List<ClienteDTO> lista = business.Listar();

            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = lista;
        }
        
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            Form cadClientes = new frmCadCliente();
            cadClientes.Show();
        }
    }
}
