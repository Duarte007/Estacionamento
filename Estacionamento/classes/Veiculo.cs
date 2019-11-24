using System;
using System.Collections.Generic;

namespace Estacionamento {
    public abstract class Veiculo {
            #region Atributos

        protected string placa;

        protected List<Estacionada> usos = new List<Estacionada>();
        protected string porte;

        #endregion

        #region GetSets

        public string getPlaca() {
            return this.placa;
        }

        public string getPorte() {
            return this.porte;
        }

        public void setPlaca(string placa) {
            try {
                if (placa != "" && placa.Length == 8) {
                    this.placa = placa;
                }
            } catch (FormatException) {
                Console.WriteLine("O formato dos dados da placa está incorreto");
            } catch (ArgumentNullException) {
                Console.WriteLine("A string passada como valor da placa está vazia!");
            }
        }

        public List<Estacionada> getUsos() {
            return this.usos;
        }

        public void setUsos(Estacionada estacionada) {
            try {
                this.usos.Add(estacionada);
            } catch (FormatException) {
                Console.WriteLine("O formato de algum dos parâmetros não é válido!");
            } catch (ArgumentException) {
                Console.WriteLine("Algum dos parâmetros não é válido!");
            }
        }
        #endregion

        #region Métodos

        public abstract double tarifa(Estacionada quando);

        public abstract double tarifaTotal();

        #endregion
    }
}
