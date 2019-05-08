namespace TelasTCC
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gbMunu = new System.Windows.Forms.GroupBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.gbMunu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMunu
            // 
            this.gbMunu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbMunu.Controls.Add(this.btnEstoque);
            this.gbMunu.Controls.Add(this.btnFornecedores);
            this.gbMunu.Controls.Add(this.btnCliente);
            this.gbMunu.Controls.Add(this.btnVendas);
            this.gbMunu.Controls.Add(this.btnFinanceiro);
            this.gbMunu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMunu.Location = new System.Drawing.Point(30, 40);
            this.gbMunu.Name = "gbMunu";
            this.gbMunu.Size = new System.Drawing.Size(247, 389);
            this.gbMunu.TabIndex = 0;
            this.gbMunu.TabStop = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEstoque.Location = new System.Drawing.Point(6, 325);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(234, 50);
            this.btnEstoque.TabIndex = 5;
            this.btnEstoque.Text = "Módulo de funcionários";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFornecedores.Location = new System.Drawing.Point(6, 250);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(234, 50);
            this.btnFornecedores.TabIndex = 4;
            this.btnFornecedores.Text = "Módulo de fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCliente.Location = new System.Drawing.Point(6, 175);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(234, 50);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Módulo de clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVendas.Location = new System.Drawing.Point(6, 100);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(234, 50);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Módulo de vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFinanceiro.Location = new System.Drawing.Point(6, 25);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(234, 50);
            this.btnFinanceiro.TabIndex = 0;
            this.btnFinanceiro.Text = "Módulo financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gbMunu);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.gbMunu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMunu;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnEstoque;
    }
}