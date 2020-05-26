using System;
// using System.Collections.Generic;

namespace Bank
{
  class Program
  {

    static void Main(string[] args)
    {
      Client leonardo = new Client("Leonardo", "033.377.932-07", "68299", "Avenida Castro Alves", 23);

      // Conta contaLeonardo = new Conta(25356, leonardo, 1500);

      ContaPoupanca c = new ContaPoupanca(25356, leonardo, 0);

      c.depositaCaixa(100);

      c.retira(50);

      System.Console.WriteLine(c.Saldo);


    }
  }
}