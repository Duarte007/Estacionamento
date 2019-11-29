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
    public partial class frm_GridCliente : Form
    {
        public frm_GridCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_GridCliente_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Cliente> clientes = frm_CadastroCliente.getClientes();
            
            foreach (Cliente cliente in clientes) {
                string[] row = {
                    cliente.getCpf(), cliente.getNome(), cliente.getPlano(), cliente.getVeiculo().getPlaca() };
                this.dataGridView1.Rows.Add(row);
            }

            //songsDataGridView.Columns[0].DisplayIndex = 3;
            
        }
    }
}
