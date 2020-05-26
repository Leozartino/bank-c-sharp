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

      Conta c = new ContaPoupanca(25356, leonardo, 170);
      Conta d = new ContaPoupanca(52169, pedro, 150);

      TotalizadorContas conta01 = new TotalizadorContas();

      conta01.Soma(c);
      conta01.Soma(d);

      System.Console.WriteLine(conta01.ValorTotal);

    }
  }
}