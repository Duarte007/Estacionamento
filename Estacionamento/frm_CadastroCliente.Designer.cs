namespace Estacionamento
{
    partial class frm_CadastroCliente
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
            this.cbx_Plano = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupCliente = new System.Windows.Forms.GroupBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupVeiculos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mkt1_placa = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_porte = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.GrupCliente.SuspendLayout();
            this.GroupVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Plano
            // 
            this.cbx_Plano.FormattingEnabled = true;
            this.cbx_Plano.Items.AddRange(new object[] {
            "Horista",
            "Diarista",
            "Mensalista"});
            this.cbx_Plano.Location = new System.Drawing.Point(19, 147);
            this.cbx_Plano.Name = "cbx_Plano";
            this.cbx_Plano.Size = new System.Drawing.Size(199, 21);
            this.cbx_Plano.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plano";
            // 
            // mkt_CPF
            // 
            this.mkt_CPF.Location = new System.Drawing.Point(19, 99);
            this.mkt_CPF.Mask = "000.000.000-00";
            this.mkt_CPF.Name = "mkt_CPF";
            this.mkt_CPF.Size = new System.Drawing.Size(199, 20);
            this.mkt_CPF.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";
            // 
            // GrupCliente
            // 
            this.GrupCliente.Controls.Add(this.txt_nome);
            this.GrupCliente.Controls.Add(this.label3);
            this.GrupCliente.Controls.Add(this.label2);
            this.GrupCliente.Controls.Add(this.mkt_CPF);
            this.GrupCliente.Controls.Add(this.label1);
            this.GrupCliente.Controls.Add(this.cbx_Plano);
            this.GrupCliente.Location = new System.Drawing.Point(12, 51);
            this.GrupCliente.Name = "GrupCliente";
            this.GrupCliente.Size = new System.Drawing.Size(248, 220);
            this.GrupCliente.TabIndex = 7;
            this.GrupCliente.TabStop = false;
            this.GrupCliente.Text = "Cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(19, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(199, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // GroupVeiculos
            // 
            this.GroupVeiculos.Controls.Add(this.label5);
            this.GroupVeiculos.Controls.Add(this.mkt1_placa);
            this.GroupVeiculos.Controls.Add(this.label6);
            this.GroupVeiculos.Controls.Add(this.cmb_porte);
            this.GroupVeiculos.Location = new System.Drawing.Point(334, 51);
            this.GroupVeiculos.Name = "GroupVeiculos";
            this.GroupVeiculos.Size = new System.Drawing.Size(248, 220);
            this.GroupVeiculos.TabIndex = 9;
            this.GroupVeiculos.TabStop = false;
            this.GroupVeiculos.Text = "Veiculos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Placa";
            // 
            // mkt1_placa
            // 
            this.mkt1_placa.Location = new System.Drawing.Point(18, 51);
            this.mkt1_placa.Mask = "AAA-0000";
            this.mkt1_placa.Name = "mkt1_placa";
            this.mkt1_placa.Size = new System.Drawing.Size(199, 20);
            this.mkt1_placa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Porte";
            // 
            // cmb_porte
            // 
            this.cmb_porte.FormattingEnabled = true;
            this.cmb_porte.Items.AddRange(new object[] {
            "Pequeno",
            "Grande",
            "Moto"});
            this.cmb_porte.Location = new System.Drawing.Point(18, 99);
            this.cmb_porte.Name = "cmb_porte";
            this.cmb_porte.Size = new System.Drawing.Size(199, 21);
            this.cmb_porte.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(498, 303);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 356);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.GroupVeiculos);
            this.Controls.Add(this.GrupCliente);
            this.Name = "frm_CadastroCliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.frm_CadastroCliente_Load);
            this.GrupCliente.ResumeLayout(false);
            this.GrupCliente.PerformLayout();
            this.GroupVeiculos.ResumeLayout(false);
            this.GroupVeiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Plano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrupCliente;
        private System.Windows.Forms.GroupBox GroupVeiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mkt1_placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_porte;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
    }
}