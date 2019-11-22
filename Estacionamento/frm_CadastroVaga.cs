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
        public frm_CadastroVaga()
        {
            InitializeComponent();
        }

        // public List<Vaga> vaga = new List<Vaga>();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vaga.Add(new Vaga(txtIdVaga.Text));



            String s;
            int i;
            String[] dadosVagas;
            String arqVagas = @"C:\Users\Ian\Desktop\Estacionamento\DadosPOOVagasEstacionamento.txt";
            int numeroLinhas = System.IO.File.ReadAllLines(arqVagas).Length;
            Vaga[] vaga = new Vaga[numeroLinhas];
            StreamReader arquivoLeitura;

            if (File.Exists(arqVagas))
            {
                arquivoLeitura = new StreamReader(arqVagas, Encoding.ASCII);
                s = arquivoLeitura.ReadLine();
                i = 0;

                while (s != null)
                {
                    dadosVagas = s.Split(';');
                  //  string servM, servL;
                  //  if (dadosVagas[1] == "True")
                  //  {
                  //      servM =
                  //  }
                    vaga[i] = new Vaga(dadosVagas[0]);

                }
                // fecha e libera o arquivo de entrada.
                arquivoLeitura.Close();

                MessageBox.Show("Vaga Adicionada com sucesso");
            }
        }
    }
}