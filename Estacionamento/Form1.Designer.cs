namespace Estacionamento
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.relaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vagaToolStripMenuItem,
            this.servicosToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cToolStripMenuItem.Text = "Cadastro";
            // 
            // vagaToolStripMenuItem
            // 
            this.vagaToolStripMenuItem.Name = "vagaToolStripMenuItem";
            this.vagaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vagaToolStripMenuItem.Text = "Vaga";
            this.vagaToolStripMenuItem.Click += new System.EventHandler(this.vagaToolStripMenuItem_Click);
            // 
            // servicosToolStripMenuItem
            // 
            this.servicosToolStripMenuItem.Name = "servicosToolStripMenuItem";
            this.servicosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.servicosToolStripMenuItem.Text = "Servicos";
            this.servicosToolStripMenuItem.Click += new System.EventHandler(this.servicosToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.empresaToolStripMenuItem.Text = "Cliente";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receberToolStripMenuItem,
            this.entradaToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // receberToolStripMenuItem
            // 
            this.receberToolStripMenuItem.Name = "receberToolStripMenuItem";
            this.receberToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.receberToolStripMenuItem.Text = "Entrada";
            this.receberToolStripMenuItem.Click += new System.EventHandler(this.receberToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "Saida";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veiculosToolStripMenuItem,
            this.vagasToolStripMenuItem,
            this.planosToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // vagasToolStripMenuItem
            // 
            this.vagasToolStripMenuItem.Name = "vagasToolStripMenuItem";
            this.vagasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vagasToolStripMenuItem.Text = "Vagas";
            this.vagasToolStripMenuItem.Click += new System.EventHandler(this.vagasToolStripMenuItem_Click);
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.planosToolStripMenuItem.Text = "Planos";
            this.planosToolStripMenuItem.Click += new System.EventHandler(this.planosToolStripMenuItem_Click);
            // 
            // relaToolStripMenuItem
            // 
            this.relaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioToolStripMenuItem,
            this.vagaToolStripMenuItem1,
            this.faturamentoToolStripMenuItem});
            this.relaToolStripMenuItem.Name = "relaToolStripMenuItem";
            this.relaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relaToolStripMenuItem.Text = "Relatório";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Cliente";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // vagaToolStripMenuItem1
            // 
            this.vagaToolStripMenuItem1.Name = "vagaToolStripMenuItem1";
            this.vagaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vagaToolStripMenuItem1.Text = "Vaga";
            this.vagaToolStripMenuItem1.Click += new System.EventHandler(this.VagaToolStripMenuItem1_Click);
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            this.faturamentoToolStripMenuItem.Click += new System.EventHandler(this.FaturamentoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 565);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
    }
}

