using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento {
    public class ClienteHorista:Cliente {
        #region Atributos

        const double tarifa_hora = 8;
        public string planoCliente = "Horista";

        #endregion

        public ClienteHorista(string nome, string cpf, Veiculo veiculo) {
            this.nome = nome;
            this.cpf = cpf;
            this.veiculo = veiculo;
        }

        #region GetSets


        public override string getPlano() {
            return this.planoCliente;
        }
        double getTarifaHora() {
            return tarifa_hora;
        }

        #endregion

        #region Métodos

        #endregion

    }

}
