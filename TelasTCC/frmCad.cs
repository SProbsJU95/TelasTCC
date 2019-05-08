using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasTCC.DB.Usuario;

namespace TelasTCC
{
    public partial class frmCad : Form
    {
        public frmCad()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtConfSenha.Text)) {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Nome = txtNome.Text;
                dto.Usuario = txtUsuario.Text;
                dto.Senha = txtSenha.Text;
                dto.ConfirmarSenha = txtConfSenha.Text;
                dto.Celular = txtCell.Text;
                dto.CPF = txtCpf.Text;
                dto.Salario = txtSalario.Text;
                dto.Funcao = txtFuncao.Text;

                UsuarioBusiness business = new UsuarioBusiness();
                business.Salvar(dto);

                MessageBox.Show("Usuário cadastrado.");
                Form login = new frmLogin();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senhas diferentes");
                txtSenha.Text = "";
                txtConfSenha.Text = "";
                txtSenha.Focus();
            }
        }
    }
}
