using System;
using System.Collections.Generic;


namespace Estacionamento {
    public class Vaga {
        public IServico[] servicos = new IServico[2];
        public string id;

    // public IServico[] Servicos { get => Servicos; set => Servicos = value; }

        public Vaga(string id)  {
            this.id = id;        
        }

        public IServico[] getServicos(){
            return this.servicos;
        }

        public List<Estacionada> getHistoricoVaga(){

            List<Estacionada> historicoVaga = new List<Estacionada>();

            foreach (Veiculo veiculoCadastrado in frm_CadastroCliente.getVeiculos()) {
                foreach (Estacionada uso in veiculoCadastrado.getUsos()) {
                    if(uso.getVaga().id == this.id){
                        historicoVaga.Add(uso);
                    }
                }
            }

            return historicoVaga;

        }
    }
}
