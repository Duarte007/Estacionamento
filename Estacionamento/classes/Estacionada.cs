using System;


namespace Estacionamento {
    public class Estacionada {
        private Vaga vaga;
        private DateTime entrada;
        private DateTime saida;


        public Estacionada(Vaga vaga, DateTime entrada, DateTime saida){
            this.vaga = vaga;
            this.entrada = entrada;
            this.saida = saida;
        }

        public DateTime getSaida(){
            return this.saida;
        }

        public DateTime getEntrada(){
            return this.entrada;
        }

        public Vaga getVaga(){
            return this.vaga;
        }

    }
}
