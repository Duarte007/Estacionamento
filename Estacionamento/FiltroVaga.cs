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
    public partial class FiltroVaga : Form
    {

        public string filtro;
        public FiltroVaga()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.filtro = txtFiltroVaga.Text;
            StreamWriter relatorio;
            relatorio = new StreamWriter(@"..\..\..\Dados\relatorioVaga.txt", false, Encoding.ASCII);
            List<Estacionada> historico = new List<Estacionada>();
            List<Cliente> clientes = frm_CadastroCliente.getClientes();
            // foreach (Cliente cliente in clientes){
            //     foreach(Estacionada es in cliente.getVeiculo().getUsos()){
            //         if(es.getVaga().id == filtro){

            //             historico = es.getVaga().getHistoricoVaga();
            //         }
            //     }
            // }
            foreach (Vaga vaga in frm_CadastroVaga.getVagas()){
                if(vaga.id == filtro){
                    historico = vaga.getHistoricoVaga();
                }
            }
            relatorio.WriteLine("Relatorio Vaga: " + this.filtro);
            for (int i = 0; i < historico.Count; i++) {
                relatorio.WriteLine(" Entrada: " + historico[i].getEntrada() + " Saida: " + historico[i].getSaida());
            }

            relatorio.Close();

            MessageBox.Show("Relatório gerado com sucesso. Verifique o arquivo ./Dados/relatorioVaga.txt");
        }
    }
}
