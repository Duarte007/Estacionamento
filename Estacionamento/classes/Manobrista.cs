using System;

public class Manobrista:IServico {
    public Manobrista() {
    }

    public static double PrecoManobrista;

    #region IServico members

    /// <summary>
    /// 
    /// </summary>
    /// <returns>Retorna o Valor do Manobrista</returns>
    public double valor() {
        return PrecoManobrista;
    }
    #endregion
}
