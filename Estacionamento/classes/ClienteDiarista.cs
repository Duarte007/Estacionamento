using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento {
    public class ClienteDiarista : Cliente {
        #region Atributos

        const double tarifa_dia = 30;
        public string planoCliente = "Diário";

        #endregion

        public ClienteDiarista(string nome, string cpf, Veiculo veiculo) {
            this.nome = nome;
            this.cpf = cpf;
            this.veiculo = veiculo;
        }

        #region GetSets

        public override string getPlano() {
            return this.planoCliente;
        }

        double getTarifaDia() {
            return tarifa_dia;
        }

        #endregion

        #region Métodos


        #endregion
    }
}
