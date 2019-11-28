using System;

namespace Estacionamento {
    public class Moto:Veiculo {

        #region Atributos

        const double tarifaBasica = 5;
        private double desconto = 1.3;

        #endregion

        #region Construtores

        public Moto(string placa) {
            this.porte = "Moto";
            setPlaca(placa);

        }

        #endregion

        #region GetSets
        public double getTarifaBasica() {
            return tarifaBasica;
        }

        public double getDesconto() {
            return desconto;
        }

        public void setDesconto(double valor, double tarifaBasica) {

            if (valor > 0 && valor < tarifaBasica)

                try {
                    this.desconto = valor;
                } catch (ArgumentNullException) {
                    Console.WriteLine("O parâmetro está nulo!");
                } catch (FormatException) {
                    Console.WriteLine("Oformato do parâmetro está incorreto!");
                } catch (ArgumentException) {
                    Console.WriteLine("O parâmetro não é válido!");
                }

        }


        #endregion

        
        #region Métodos
        public override double tarifa(Estacionada quando) {
            double tarifaFinal = 0;
            int tarifaHora = 5;
            TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());
            tarifaFinal = (tarifaHora - getDesconto()) * tempoEstacionada.Hours;
            return tarifaFinal;
        }

        public override double tarifaTotal() {
            double tarifaFinal = 0;
            int tarifaHora = 5;
            foreach (Estacionada uso in this.getUsos()) {
                TimeSpan tempoEstacionada = uso.getSaida().Subtract(uso.getEntrada());
                tarifaFinal += (tarifaHora - getDesconto()) * tempoEstacionada.Hours;
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
