﻿using System;
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
    public partial class frmModFornecedores : Form
    {
        public frmModFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form cadFornecedores = new frmCadFornecedor();
            cadFornecedores.Show();
        }
    }
}
