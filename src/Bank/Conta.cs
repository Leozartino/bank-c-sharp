namespace Bank {

  public abstract class Conta {
    protected const bool V = true;

    protected Client titular;

    protected int numero;
    public int Numero {
      get {
        return this.numero;
      }
      protected set {
        this.numero = value;
      }
    }
    protected double saldo;
    public double Saldo {
      get {
        return this.saldo;
      }
      protected set {
        this.saldo = value;
      }
    }

    public Conta (int numero, Client titular, double saldo) {
      this.numero = numero;
      this.titular = titular;
      this.saldo = saldo;
    }
    public abstract void retira (double valor);
    public bool saca (double valor) {

      if (this.saldo < valor) {
        return false;
      }
      this.saldo -= valor;
      return V;

    }

    public abstract void depositaCaixa (double valor);

    public void transfere (double valor, Conta contaDestino) {
      if (this.saca (valor)) {
        contaDestino.saldo += valor;
      }
    }
  }
}