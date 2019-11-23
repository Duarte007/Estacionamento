using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

    public double valorTarifa(Estacionada quando) {
        double tarifaFinal = 0d;

        TimeSpan tempoEstacionada = quando.getSaida().Subtract(quando.getEntrada());

        tarifaFinal = getTarifaMensal() * (tempoEstacionada.Days/30);

        foreach( IServico servico in quando.getVaga().getServicos()){
            if(servico != null){
                tarifaFinal += servico.valor();    
            }
        }
        return tarifaFinal;
    }

    #endregion

}

