using System;

public class Estacionada
{
    private Vaga vaga;
    private DateTime entrada;
    private DateTime saida;
	public Estacionada() {

	}

    public DateTime getSaida(){
        return this.saida;
    }

    public DateTime getEntrada(){
        return this.entrada;
    }

    public Estacionada(Vaga vaga, DateTime entrada, DateTime saida)
    {
        this.vaga = vaga;
        this.entrada = entrada;
        this.saida = saida;
    }
}
