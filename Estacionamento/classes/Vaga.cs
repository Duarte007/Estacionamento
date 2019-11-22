using System;

public class Vaga
{
    public IServico[] servicos = new IServico[2];
    public string id;

   // public IServico[] Servicos { get => Servicos; set => Servicos = value; }

    public Vaga(string id)
	{
        this.id = id;        
	}

    public IServico[] getServico(){
        return this.servicos;
    }
}
