using System;
// using System.Collections.Generic;

namespace Bank
{
  class Program
  {

    static void Main(string[] args)
    {
      Client leonardo = new Client("Leonardo", "033.377.932-07", "68299", "Avenida Castro Alves", 23);
      Client pedro = new Client("Pedro", "053.367.932-01", "91209", "Avenida Castro Alves", 23);

      Conta c = new Conta(25356, leonardo, 100);
      ContaPoupanca d = new ContaPoupanca(52169, pedro, 150);

      d.retira(50);
      System.Console.WriteLine($"{d.Saldo} {c.Saldo}");

      TotalizadorContas somasContas = new TotalizadorContas();

      somasContas.Soma(c);
      somasContas.Soma(d);

      System.Console.WriteLine(somasContas.ValorTotal);

    }
  }
}