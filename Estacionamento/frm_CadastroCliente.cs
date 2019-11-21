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
    public partial class frm_CadastroCliente : Form
    {
        public frm_CadastroCliente()
        {
            InitializeComponent();
        }

        public static List <Veiculo> veic = new List<Veiculo>();
        public static List<Cliente> cli = new List<Cliente>();

        
 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, cpf, plano, placa, porte;

            nome = txt_nome.Text;
            cpf = mkt_CPF.Text;
            plano = cbx_Plano.Text;
            placa = mkt1_placa.Text;
            porte = cmb_porte.Text;

           

            switch (porte)
            {
                
                case "Pequeno":
                   veic.Add(new CarroPequeno(placa));
                    break;
                case "Grande":
                    veic.Add(new CarroGrande(placa));
                    break;
                case "Moto":
                    veic.Add(new Moto(placa));
                    break;

                default:
                    break;
            }

            switch (plano)
            {
                case "Horista":
                    cli.Add(new ClienteHorista(nome, cpf, veic[veic.Count - 1]));
                    break;
                case "Diarista":
                    cli.Add(new ClienteDiarista(nome, cpf, veic[veic.Count - 1]));
                    break;
                case "Mensalista":
                    cli.Add(new ClienteMensalista(nome, cpf, veic[veic.Count - 1]));
                    break;


                default:
                    break;
            }

            this.clearFields();
            MessageBox.Show("Cliente Cadastrado com Sucesso");


        }

        private void clearFields() {
            txt_nome.Text = "";
            mkt_CPF.Text = "";
            cbx_Plano.Text = "";
            mkt1_placa.Text = "";
            cmb_porte.Text = "";
        }

        public static List<Cliente> getClientes() {
            return cli;
        }

        public static List<Veiculo> getVeiculos()
        {
            return veic;
        }

        private void frm_CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
