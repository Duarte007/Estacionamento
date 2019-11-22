using System;

public class Vaga
{
    private IServico[] servicos;
    public string id;

    public IServico[] Servicos { get => servicos; set => servicos = value; }

    public Vaga(string id)
	{
        this.id = id;        
	}
}
