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
    public partial class frm_Filtro : Form {

        public string filtro;
        public frm_Filtro() {
            InitializeComponent();
        }

        private void Btn_Filtro_Click(object sender, EventArgs e) {
            this.filtro = txt_Filtro.Text;
            StreamWriter relatorio;
            relatorio = new StreamWriter(@"..\..\..\Dados\relatorioCliente.txt", false, Encoding.ASCII);
            Cliente cliente = frm_CadastroCliente.getClientes()
                                                     .Find(cli => cli.getCpf() == filtro);
            List<Estacionada> historico = cliente.getHistorico();
            string preco = cliente.valorTarifa() > 0 ? cliente.valorTarifa().ToString("c") : cliente.getVeiculo().tarifaTotal().ToString("c");
            relatorio.WriteLine("Relatorio do Cliente: "+cliente.getNome());
            for(int i = 0 ; i < historico.Count ; i++){
                 relatorio.WriteLine("Vaga: "+historico[i].getVaga().id+" | Entrada: "+historico[i].getEntrada()+" Saida: "+historico[i].getSaida());
            }
            relatorio.WriteLine("Valor total: "+preco);

            relatorio.Close();        

            MessageBox.Show("Relatório gerado com sucesso. Verifique o arquivo ./Dados/relatorioCliente.txt");                                  
        }
    }
}
