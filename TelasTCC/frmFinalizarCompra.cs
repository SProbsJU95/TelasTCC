using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasTCC.DB.FinalizarCompra;

namespace TelasTCC
{
    public partial class frmFinalizarCompra : Form
    {
        public frmFinalizarCompra()
        {
            InitializeComponent();

            FinalizarCompraDatabase database = new FinalizarCompraDatabase();

            database.Listar();

            FinalizarCompraDTO user = new FinalizarCompraDTO();

            lblCliente.Text = "Cliente: " + user.Nome;
            lblEndereco.Text = "Endereço: " + user.Celular;
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            lblCliente.Text = "Cliente:       " + "Gabriella";
            lblEndereco.Text = "Endereço:  " + "Acesso Tucano Preto " + "Nº: " + "373";
            lblTelefone.Text = "Telefone:    " + "(11) 99019-4890";
        }
    }
}
