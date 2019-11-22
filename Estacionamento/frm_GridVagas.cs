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
    public partial class frm_GridVagas : Form
    {
        public frm_GridVagas()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_GridVagas_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            Vaga[] vagas = frm_CadastroVaga.getVagas();

            for (int i = 0; i < vagas.Length; i++)
            {
                string[] row = { vagas[i].id, "1", retornarValorServicos(vagas[i]), "" };

                this.dataGridView1.Rows.Add(row);
            }
        }

        //songsDataGridView.Columns[0].DisplayIndex = 3;


        public string checarSituacao(Estacionada estacionada)
        {
            string situacao = "";

            int valor = 0;

            if (estacionada.getSaida() == null)
            {

                return "Ocupada";

            }

            else if (estacionada.getEntrada() == null)
            {

                return "Desocupada";

            }

            else if (estacionada.getSaida() != null)
            {

                valor = estacionada.getSaida().CompareTo(DateTime.Now);

                if (valor < 0)
                {

                    return situacao = "Desocupada";

                }

                else if (valor == 0)

                {

                    return situacao = "Desocupando agora";

                }

                else

                {

                    return situacao = "Ocupada";

                }

            }
            return situacao;

        }

        public double retornarTarifa(Veiculo veiculo, Estacionada quando)
        {

            return veiculo.tarifa(quando);

        }

        public string retornarValorServicos(Vaga vaga)
        {
            double total = 0;

            for (int i = 0; i < vaga.servicos.Length; i++)
            {
                if(vaga.servicos[i] != null)
                    total += vaga.servicos[i].valor();
              
            }

            return total.ToString("c");
           
        }







    }
}



