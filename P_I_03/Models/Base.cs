using P_I_03.Models;

namespace P_I_03.Models
{

  public static class Base
  {
    public static Servico servicoAtual { get; set; }
    static Base()
    {
      servicoAtual = new Servico();

      OrcamentoAtual = new Orcamento();
    }

    public static Orcamento OrcamentoAtual{get;set;}





   
  }
}  