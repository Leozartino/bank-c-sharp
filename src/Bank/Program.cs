using System;
// using System.Collections.Generic;

namespace Bank {
  class Program {

    static void Main (string[] args) {
      Client leonardo = new Client ("Leonardo", "033.377.932-07", "68299", "Avenida Castro Alves", 23);
      Client pedro = new Client ("Pedro", "053.367.932-01", "91209", "Avenida Castro Alves", 23);

      // Polimorfismo, podemos guardar em um array de Conta
      // qualquer objeto do tipo Conta (incluindo classes que herdam de conta)
      Conta[] conta = new Conta[2];

      conta[0] = new ContaCorrente (5214, leonardo, 1500);
      conta[1] = new ContaPoupanca (1014, pedro, 1000);

      foreach (Conta c in conta) {
        System.Console.WriteLine (c.Saldo);
      }

    }
  }
}