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

            for (int i = 0 ; i < vagas.Length ; i++)
            {
                string[] row = {
                    vagas[i].id, "1", "1", "2" };
                this.dataGridView1.Rows.Add(row);
            }

            //songsDataGridView.Columns[0].DisplayIndex = 3;

        }
    }
}
