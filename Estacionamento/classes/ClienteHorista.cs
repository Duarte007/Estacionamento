using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClienteHorista:Cliente {
    #region Atributos

    const double tarifa_hora = 8;
    public static string plano = "Horista";

    #endregion

    public ClienteHorista(string nome, string cpf, Veiculo veiculo) {
        this.nome = nome;
        this.cpf = cpf;
        this.veiculo = veiculo;
    }

    #region GetSets

    double getTarifaHora() {
        return tarifa_hora;
    }

    #endregion

    #region Métodos
    public double valorTarifa(Estacionada quando) {

        double tarifaFinal = 0;
        
        TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());

        tarifaFinal = getTarifaHora() * tempoEstacionada.Hours;

        foreach( IServico servico in quando.getVaga().getServicos()){
            if(servico != null){
                tarifaFinal += servico.valor();    
            }
        }

        return tarifaFinal;
        
    }

    #endregion

}

