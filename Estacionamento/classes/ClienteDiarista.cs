using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento {
    public class ClienteDiarista : Cliente {
        #region Atributos

        const double tarifa_dia = 30;
        public static string plano = "Diário";

        #endregion

        public ClienteDiarista(string nome, string cpf, Veiculo veiculo) {
            this.nome = nome;
            this.cpf = cpf;
            this.veiculo = veiculo;
        }

        #region GetSets

        double getTarifaDia() {
            return tarifa_dia;
        }

        #endregion

        #region Métodos


        public override double valorTarifa() {
            double tarifa_final = 0;            
            
            foreach (Estacionada uso in this.veiculo.getUsos()) {
                TimeSpan diasEstacionada = uso.getSaida().Subtract(uso.getEntrada());
                tarifa_final += getTarifaDia() * diasEstacionada.Days;
                foreach( IServico servico in uso.getVaga().getServicos()){
                    if(servico != null){
                        tarifa_final += servico.valor();    
                    }
                }
            }

            return tarifa_final;

        }
        #endregion
    }
}
