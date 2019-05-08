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
    public partial class frmModVendas : Form
    {
        public frmModVendas()
        {
            InitializeComponent();
        }

        private string horario = "";

        private void setHorario(string hora)
        {
            this.horario = hora;
        }

        private string getHorario()
        {
            return horario;
        }

        private void btnPizzaria_Click(object sender, EventArgs e)
        {
            this.setHorario("Pizzaria");
        }
        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            this.setHorario("Restaurante");
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O cliente está cadastrado?", "Cliente cadastrado?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes){
                this.Height = 332;
                txtTellCliente.Focus();
            }
            else
            {
                Form cadastro = new frmCadCliente();
                cadastro.Show();
            }
        }

        private void frmModVendas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalao_Click(object sender, EventArgs e)
        {
            if (this.horario == "Pizzaria")
            {
                Form pizza = new frmPizzaria();
                pizza.Show();
                //this.Hide();
            }
            else if (this.horario == "Restaurante")
            {
                Form restaurante = new frmRestaurante();
                restaurante.Show();
                //this.Hide();
            }
        }
    }
}
