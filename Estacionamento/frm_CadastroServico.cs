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
    public partial class frm_CadastroServico : Form
    {
        public frm_CadastroServico()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            txtPrecoL.Text = txtPrecoL.Text != "" ? txtPrecoL.Text : Lavagem.PrecoLavagem.ToString();
            txtPrecoM.Text = txtPrecoM.Text != "" ? txtPrecoM.Text : Manobrista.PrecoManobrista.ToString();
            Lavagem.PrecoLavagem = Convert.ToDouble(txtPrecoL.Text);
            Manobrista.PrecoManobrista= Convert.ToDouble(txtPrecoM.Text);

            setPrices();

            MessageBox.Show("Serviços adicionados com sucesso");
        }

        private void frm_CadastroServico_Load(object sender, EventArgs e)
        {
            setPrices();
        }

        private void setPrices()
        {
            lblLavagem.Text = Lavagem.PrecoLavagem.ToString("C");
            lblManobrista.Text = Manobrista.PrecoManobrista.ToString("C");
        }
    }
}
