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
    public partial class frmModFuncionarios : Form
    {
        public frmModFuncionarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gbDados.Height == 115)
            {
                gbDados.Height = 85;
                this.Height = 379;
            }
            else
            {
                gbDados.Height = 115;
                this.Height = 404;
            }
        }
    }
}
