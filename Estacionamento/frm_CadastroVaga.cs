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
    public partial class frm_CadastroVaga : Form
    {

        public static Vaga[] vaga;
        public frm_CadastroVaga()
        {
            InitializeComponent();
        }

        // public List<Vaga> vaga = new List<Vaga>();

        public void btnSalvar_Click(object sender, EventArgs e) {
            //vaga.Add(new Vaga(txtIdVaga.Text));

            String s;
            int i;
            String[] dadosVagas;
            String arqVagas = @"..\..\..\Dados\POOVagasEstacionamento.txt";
            int numeroLinhas = System.IO.File.ReadAllLines(arqVagas).Length;
            vaga = new Vaga[numeroLinhas];
            StreamReader arquivoLeitura;

            if (File.Exists(arqVagas)) {
                arquivoLeitura = new StreamReader(arqVagas, Encoding.ASCII);
                s = arquivoLeitura.ReadLine();
                i = 0;

                while (s != null) {
                    dadosVagas = s.Split(';');
                
                    vaga[i] = new Vaga(dadosVagas[0]);
                    int auxServico = 0;
                    if (dadosVagas[1] == "True") {
                        vaga[i].servicos[auxServico] = new Manobrista();
                        auxServico++;
                    }
                    if (dadosVagas[2] == "True") {
                        vaga[i].servicos[auxServico] = new Lavagem();
                        auxServico++;
                    }
                    s = arquivoLeitura.ReadLine();
                    i++;
                }
                // fecha e libera o arquivo de entrada.
                arquivoLeitura.Close();

                MessageBox.Show("Vagas Adicionadas com sucesso");
            }
        }

        public static void saveVagas(){
            String s;
            int i;
            String[] dadosVagas;
            String arqVagas = @"..\..\..\Dados\POOVagasEstacionamento.txt";
            int numeroLinhas = System.IO.File.ReadAllLines(arqVagas).Length;
            vaga = new Vaga[numeroLinhas];
            StreamReader arquivoLeitura;

            if (File.Exists(arqVagas)) {
                arquivoLeitura = new StreamReader(arqVagas, Encoding.ASCII);
                s = arquivoLeitura.ReadLine();
                i = 0;

                while (s != null) {
                    dadosVagas = s.Split(';');
                
                    vaga[i] = new Vaga(dadosVagas[0]);
                    int auxServico = 0;
                    if (dadosVagas[1] == "True") {
                        vaga[i].servicos[auxServico] = new Manobrista();
                        auxServico++;
                    }
                    if (dadosVagas[2] == "True") {
                        vaga[i].servicos[auxServico] = new Lavagem();
                        auxServico++;
                    }
                    s = arquivoLeitura.ReadLine();
                    i++;
                }
                // fecha e libera o arquivo de entrada.
                arquivoLeitura.Close();

            }
        }

        private void Frm_CadastroVaga_Load(object sender, EventArgs e)
        {

        }

        public static Vaga[] getVagas()
        {
            return vaga;
        }
    }
}