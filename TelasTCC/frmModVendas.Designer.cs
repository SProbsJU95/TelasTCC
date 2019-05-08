namespace TelasTCC
{
    partial class frmModVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnPizzaria = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalao = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFazerEntrega = new System.Windows.Forms.Button();
            this.txtTellCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestaurante);
            this.groupBox1.Controls.Add(this.btnPizzaria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnRestaurante.Location = new System.Drawing.Point(5, 91);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(210, 50);
            this.btnRestaurante.TabIndex = 2;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // btnPizzaria
            // 
            this.btnPizzaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPizzaria.Location = new System.Drawing.Point(6, 19);
            this.btnPizzaria.Name = "btnPizzaria";
            this.btnPizzaria.Size = new System.Drawing.Size(210, 50);
            this.btnPizzaria.TabIndex = 1;
            this.btnPizzaria.Text = "Pizzaria";
            this.btnPizzaria.UseVisualStyleBackColor = true;
            this.btnPizzaria.Click += new System.EventHandler(this.btnPizzaria_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalao);
            this.groupBox2.Controls.Add(this.btnEntrega);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSalao
            // 
            this.btnSalao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSalao.Location = new System.Drawing.Point(5, 91);
            this.btnSalao.Name = "btnSalao";
            this.btnSalao.Size = new System.Drawing.Size(210, 50);
            this.btnSalao.TabIndex = 2;
            this.btnSalao.Text = "Salão";
            this.btnSalao.UseVisualStyleBackColor = true;
            this.btnSalao.Click += new System.EventHandler(this.btnSalao_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEntrega.Location = new System.Drawing.Point(6, 19);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(210, 50);
            this.btnEntrega.TabIndex = 1;
            this.btnEntrega.Text = "Entrega";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFazerEntrega);
            this.groupBox3.Controls.Add(this.txtTellCliente);
            this.groupBox3.Controls.Add(this.lblSabor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telefone";
            // 
            // btnFazerEntrega
            // 
            this.btnFazerEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFazerEntrega.Location = new System.Drawing.Point(314, 36);
            this.btnFazerEntrega.Name = "btnFazerEntrega";
            this.btnFazerEntrega.Size = new System.Drawing.Size(144, 39);
            this.btnFazerEntrega.TabIndex = 3;
            this.btnFazerEntrega.Text = "Fazer entrega";
            this.btnFazerEntrega.UseVisualStyleBackColor = true;
            // 
            // txtTellCliente
            // 
            this.txtTellCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTellCliente.Location = new System.Drawing.Point(167, 43);
            this.txtTellCliente.Mask = "(00)00000-0000";
            this.txtTellCliente.Name = "txtTellCliente";
            this.txtTellCliente.Size = new System.Drawing.Size(129, 26);
            this.txtTellCliente.TabIndex = 2;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(18, 46);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(143, 20);
            this.lblSabor.TabIndex = 1;
            this.lblSabor.Text = "Telefone do cliente";
            // 
            // frmModVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 175);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de vendas";
            this.Load += new System.EventHandler(this.frmModVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnPizzaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalao;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.MaskedTextBox txtTellCliente;
        private System.Windows.Forms.Button btnFazerEntrega;
    }
}