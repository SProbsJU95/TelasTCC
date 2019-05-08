using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasTCC.DB.Login;

namespace TelasTCC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO dto = new LoginDTO();
            //dto.Usuario = txtUsuario.Text;
            //dto.Senha = txtSenha.Text;

            LoginBusiness business = new LoginBusiness();
            business.Pesquisar();

            if (txtUsuario.Text == dto.Usuario)
            {
                Form menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            MessageBox.Show("O nome de usuario é: " + dto.Usuario + "A senha é: " + dto.Senha);
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form cad = new frmCad();
            cad.Show();
            this.Hide();
        }
    }
}
