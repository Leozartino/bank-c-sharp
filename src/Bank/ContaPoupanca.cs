namespace Bank
{
  public class ContaPoupanca : Conta
  {
    public ContaPoupanca(int numero, Client titular, double saldo) : base(numero, titular, saldo)
    {

    }
    public override void retira(double valor)
    {
      if (!this.titular.maiorDeIdade())
      {
        valor = 200 + 0.05;
        this.saca(valor);
      }
      else
      {

        this.saca(valor + 0.05);
      }
    }

    public override void depositaCaixa(double valor)
    {
      this.saldo += (valor - 0.05);
    }
  }
}