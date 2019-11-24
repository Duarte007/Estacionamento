using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento {
    public class ClienteMensalista : Cliente {
        #region Atributos

        const double tarifa_mensal = 250;
        public static string plano = "Mensal";

        #endregion

        public ClienteMensalista(string nome, string cpf, Veiculo veiculo) {
            this.nome = nome;
            this.cpf = cpf;
            this.veiculo = veiculo;
        }

        #region GetSets

        public double getTarifaMensal() {
            return tarifa_mensal;
        }

        #endregion

        #region Métodos

        public override double valorTarifa() {
            double tarifaFinal = 0d;

            foreach (Estacionada uso in this.veiculo.getUsos()) {
                TimeSpan diasEstacionada = uso.getSaida().Subtract(uso.getEntrada());
                tarifaFinal += getTarifaMensal() * (diasEstacionada.Days/30);
                foreach( IServico servico in uso.getVaga().getServicos()){
                    if(servico != null){
                        tarifaFinal += servico.valor();    
                    }
                }
            }

            return tarifaFinal;
        }

        #endregion

    }

}
