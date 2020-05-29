namespace Bank
{
  public class ContaInvestimento : Conta, ITributavel
  {
    public ContaInvestimento(int numero, Client titular, double saldo) : base(numero, titular, saldo) { }

    public override void retira(double valor)
    {
      if (!this.titular.maiorDeIdade())
      {
        valor = 200;
        this.saca(valor);
      }
      else
      {

        this.saca(valor);
      }
    }
    public override void depositaCaixa(double valor)
    {
      this.saldo += valor;
    }
    public double calculaTributo()
    {
      return this.Saldo * 0.03;
    }
  }
}