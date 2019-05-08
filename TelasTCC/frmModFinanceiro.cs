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
    public partial class frmModFinanceiro : Form
    {
        public frmModFinanceiro()
        {
            InitializeComponent();
            /*gbCaixa.Visible = false;
            gbCaixa.Enabled = false;
            dataGridPagamento.Visible = false;*/
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            /*if(gbCaixa.Visible == true)
            {
                gbCaixa.Visible = false;
                gbCaixa.Enabled = false;
            }
            dataGridPagamento.Visible = true;*/
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            /*gbCaixa.Visible = true;
            gbCaixa.Enabled = true;
            cbDia.Checked = true;
            dataGridPagamento.Visible = false;*/
        }

        private void btnVendasCard_Click(object sender, EventArgs e)
        {
            lblCartao.Text = "Vendas em cartão: " + "56";
            lblRecCartao.Text = "Recebido em cartão: " + "R$ 387,90";
            lblDinheiro.Text = "Vendas em dinheiro: " + "12";
            lblRecDinheiro.Text = "Recebido em dinheiro" + "R$ 120,50";
            lblTotal.Text = "Valor total do " + "dia: " + "R$ 508,40";
        }
    }
}
