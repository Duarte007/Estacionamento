using System;

namespace Estacionamento {
    public class CarroGrande:Veiculo {
        #region Atributos

        double valorExtra = 2;
        const double tarifaBasica = 5;

        #endregion

        #region Construtores

        public CarroGrande(string placa) {
            this.porte = "Grande";
            setPlaca(placa);
        }
        #endregion

        #region GetSets

        public double getTarifaBasica() {
            return tarifaBasica;
        }

        public double getValorExtra() {
            return valorExtra;
        }

        public void setValorExtra(double valor) {
            if (valor > 0){
                try {
                    this.valorExtra = valor;
                } catch (ArgumentNullException) {
                    Console.WriteLine("O parâmetro está nulo!");
                } catch (FormatException) {
                    Console.WriteLine("Oformato do parâmetro está incorreto!");
                } catch (ArgumentException) {
                    Console.WriteLine("O parâmetro não é válido!");
                }
            }
        }
        #endregion


        #region Métodos
        public override double tarifa(Estacionada quando) {
            double tarifaFinal = 0;
            TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());
            tarifaFinal = (getTarifaBasica() + getValorExtra()) * tempoEstacionada.Hours;
            return tarifaFinal;
        }

        public override double tarifaTotal() {
            double tarifaFinal = 0;
            foreach (Estacionada uso in this.getUsos()) {
                TimeSpan tempoEstacionada = uso.getSaida().Subtract(uso.getEntrada());
                tarifaFinal += (getTarifaBasica() + getValorExtra()) * tempoEstacionada.Hours;
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
