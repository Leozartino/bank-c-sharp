namespace Bank
{
  public class ContaPoupanca : Conta
  {
    public ContaPoupanca(int numero, Client titular, double saldo) : base(numero, titular, saldo)
    {

    }
    public override void retira(double valor)
    {
      this.saldo -= (valor + 0.10);
    }
  }
}