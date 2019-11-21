using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ClienteMensalista : Cliente {
        #region Atributos

        const double tarifa_mensal = 250;

    #endregion

    public ClienteMensalista(string nome, string cpf, Veiculo veiculo)
    {
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
           return 0d;
        }

        #endregion

    }

