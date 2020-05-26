namespace Bank
{
  public class TotalizadorContas
  {
    private double valor_total;
    public double ValorTotal
    {
      get
      {
        return this.valor_total;
      }
      private set
      {
        this.valor_total = value;
      }
    }
    public void Soma(Conta conta) => this.valor_total += conta.Saldo;

  }
}