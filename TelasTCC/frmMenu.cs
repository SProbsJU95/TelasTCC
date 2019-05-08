using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasTCC
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            Form financeiro = new frmModFinanceiro();
            financeiro.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form modClientes = new frmModClientes();
            modClientes.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Form vendas = new frmModVendas();
            vendas.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Form fornecedores = new frmModFornecedores();
            fornecedores.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Form funcionario = new frmModFuncionarios();
            funcionario.Show();

        }
    }
}
