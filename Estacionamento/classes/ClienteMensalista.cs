using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento {
    public class ClienteMensalista : Cliente {
        #region Atributos

        const double tarifa_mensal = 250;
        public string planoCliente = "Mensal";

        #endregion

        public ClienteMensalista(string nome, string cpf, Veiculo veiculo) {
            this.nome = nome;
            this.cpf = cpf;
            this.veiculo = veiculo;
        }

        #region GetSets


        public override string getPlano() {
            return this.planoCliente;
        }
        public double getTarifaMensal() {
            return tarifa_mensal;
        }

        #endregion

        #region Métodos

        #endregion

    }

}
