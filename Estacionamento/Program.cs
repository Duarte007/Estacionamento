using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Estacionamento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_CadastroVaga.saveVagas();
            frm_CadastroCliente.saveClientes();
            saveEstacionadas();
            Application.Run(new Form1());
        }

        static void saveEstacionadas(){
            String s;
            int i;
            String[] dadosClientes;
            String arqClientes = @"..\..\..\Dados\POOEstacionadas.txt";
            int numeroLinhas = System.IO.File.ReadAllLines(arqClientes).Length;
            StreamReader arquivoLeitura;
            string cpf = "", idVaga = "", entrada = "", saida = "";
            
            if (File.Exists(arqClientes)) {
                arquivoLeitura = new StreamReader(arqClientes, Encoding.ASCII);
                s = arquivoLeitura.ReadLine();
                i = 0;

                while (s != null) {
                    dadosClientes = s.Split(';');
                    cpf = dadosClientes[0];
                    idVaga = dadosClientes[1];
                    entrada = dadosClientes[2];
                    saida = dadosClientes[3];

                    Cliente cliente = frm_CadastroCliente.getClientes()
                                                    .Find(cli => cli.getCpf() == cpf);

                    foreach (Vaga vaga in frm_CadastroVaga.getVagas()){
                        if(vaga.id == idVaga){
                            cliente.getVeiculo().setUsos(new Estacionada(vaga, Convert.ToDateTime(entrada), Convert.ToDateTime(saida)));
                        }
                    }

                    s = arquivoLeitura.ReadLine();
                    i++;
                }
                // fecha e libera o arquivo de entrada.
                arquivoLeitura.Close();
            }
        }

    }
}
