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
    public partial class frm_GridVeiculos : Form
    {
        public frm_GridVeiculos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_GridVeiculos_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Cliente> clientes = frm_CadastroCliente.getClientes();

            foreach (Cliente cliente in clientes)
            {
                string[] row = { cliente.getVeiculo().getPlaca(), cliente.getNome(), cliente.getVeiculo().getPorte() };
                this.dataGridView1.Rows.Add(row);
            }

            //songsDataGridView.Columns[0].DisplayIndex = 3;

        }
    }
}
