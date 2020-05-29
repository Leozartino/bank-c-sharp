namespace Bank {
  public class ContaCorrente : Conta {

    public ContaCorrente (int numero, Client titular, double saldo) : base (numero, titular, saldo) {

    }
    public override void retira (double valor) {
      if (!this.titular.maiorDeIdade ()) {
        valor = 200;
        this.saca (valor);
      } else {

        this.saca (valor);
      }
    }
    public override void depositaCaixa (double valor) {
      this.saldo += valor;
    }
  }
}