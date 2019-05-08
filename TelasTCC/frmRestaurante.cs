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
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            txtPeso.Visible = true;
            cbRefeicao.Visible = false;
            txtPeso.Left = 373; 
        }

        private void cbFeijoada_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPratoFeito_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPeso_CheckedChanged(object sender, EventArgs e)
        {
            cbFeijoada.Checked = false;
            cbPratoFeito.Checked = false;
        }
        
        private void cbFeijoada_MouseClick(object sender, MouseEventArgs e)
        {
            cbFeijoada.Checked = true;
            cbPratoFeito.Checked = false;
            cbPeso.Checked = false;
        }

        private void cbPratoFeito_MouseClick(object sender, MouseEventArgs e)
        {
            cbPratoFeito.Checked = true;
            cbFeijoada.Checked = false;
            cbPeso.Checked = false;
        }

        private void cbPeso_MouseClick(object sender, MouseEventArgs e)
        {
            cbPeso.Checked = true;
            cbPratoFeito.Checked = false;
            cbFeijoada.Checked = false;
        }
    }
}
