using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroVaga CadVaga = new frm_CadastroVaga(); 
            CadVaga.MdiParent = this;
            CadVaga.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridCliente GrdCliente = new frm_GridCliente();
            GrdCliente.MdiParent = this;
            GrdCliente.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridVeiculos GrdVeiculos = new frm_GridVeiculos();
            GrdVeiculos.MdiParent = this;
            GrdVeiculos.Show();
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridVagas GrdVagas = new frm_GridVagas();
            GrdVagas.MdiParent = this;
            GrdVagas.Show();

        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridPlanos GrdPlanos = new frm_GridPlanos();
            GrdPlanos.MdiParent = this;
            GrdPlanos.Show();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e) {
            //frm_Relatorio rel = new frm_Relatorio();
            frm_Filtro filtro = new frm_Filtro();
            filtro.MdiParent = this;
            filtro.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCliente CadCli = new frm_CadastroCliente();
            CadCli.MdiParent = this;
            CadCli.Show();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroServico CadServ = new frm_CadastroServico();
            CadServ.MdiParent = this;
            CadServ.Show();
        }

        private void receberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OparacaoEntrada opeEntrada = new frm_OparacaoEntrada();
            opeEntrada.MdiParent = this;
            opeEntrada.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OperacaoSaida opeSaida = new frm_OperacaoSaida();
            opeSaida.MdiParent = this;
            opeSaida.Show();
        }

        private void VagaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FiltroVaga filtro = new FiltroVaga();
            filtro.MdiParent = this;
            filtro.Show();
        }

        private void FaturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter relatorio;
            relatorio = new StreamWriter(@"..\..\..\Dados\relatorioFaturamento.txt", false, Encoding.ASCII);
            List<Cliente> clientesCadastrados = frm_CadastroCliente.getClientes();

            double faturamento = 0d;
            relatorio.WriteLine("Faturamento");
            foreach(Cliente cli in clientesCadastrados) {
                double vrPago = cli.valorTarifa();
                if (vrPago == 0) vrPago = cli.getVeiculo().tarifaTotal();
                relatorio.WriteLine("Cliente: " + cli.getCpf() + " - " + cli.getNome() + " | " + "Valor Pago: " + vrPago.ToString("c"));
                
                faturamento += cli.valorTarifa();
            }
            relatorio.WriteLine("Faturamento Total: "+ faturamento.ToString("c"));

            relatorio.Close();

            MessageBox.Show("Relatório gerado com sucesso. Verifique o arquivo relatorioFaturamento.txt");
        }
    }
}
