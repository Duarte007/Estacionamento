using System;

namespace Estacionamento {
    public class CarroPequeno:Veiculo {
        #region Atributos

        const double tarifaBasica = 5;

        #endregion

        #region Construtores

        public CarroPequeno(string placa) {
            this.porte = "Pequeno";
            setPlaca(placa);
        }

        #endregion 


        #region GetSets
        public double getTarifaBasica() {
            return tarifaBasica;
        }
        #endregion

        #region Métodos 
        public override double tarifa(Estacionada quando) {
            double tarifaFinal = 0;
            TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());
            tarifaFinal = getTarifaBasica() * tempoEstacionada.Hours;
            return tarifaFinal;
            #endregion 

        }

        public override double tarifaTotal() {
            double tarifaFinal = 0;
            foreach (Estacionada uso in this.getUsos()) {
                TimeSpan tempoEstacionada = uso.getSaida().Subtract(uso.getEntrada());
                tarifaFinal = getTarifaBasica() * tempoEstacionada.Hours;
            }
            return tarifaFinal;
        }

    }
}