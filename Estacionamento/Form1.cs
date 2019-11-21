using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CadVaga.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridCliente GrdCliente = new frm_GridCliente();
            GrdCliente.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridVeiculos GrdVeiculos = new frm_GridVeiculos();
            GrdVeiculos.Show();
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridVagas GrdVagas = new frm_GridVagas();
            GrdVagas.Show();

        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GridPlanos GrdPlanos = new frm_GridPlanos();
            GrdPlanos.Show();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Relatorio rel = new frm_Relatorio();
            rel.Show();
        }
    }
}
