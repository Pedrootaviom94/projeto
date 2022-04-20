using System;
using System.Collections.Generic;

namespace P_I_03.Models
{
  public class Orcamento
  {
    public List<Servico> solicitados;
    public Orcamento ()
    {
      solicitados = new List<Servico>();
    }
    public void Incluir(Servico ser)
    {
      solicitados.Add(ser);
    }
    public List<Servico> Listagem()
    {
      return solicitados;
    }
    public double ValorTotalSolicitado()
    {
      double total = 0;
      for (int i = 0; i < solicitados.Count; i++)
      {
        total = total + solicitados[i].valor_unitario * solicitados[i].quantidade;
      }
      return total;
    }
    public int QuantidadeSolicitados()
    {
      return solicitados.Count;
    }
  }
}