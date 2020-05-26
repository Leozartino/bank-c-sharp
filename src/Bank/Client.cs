namespace Bank
{

  public class Client
  {
    public string nome;
    private string cpf;
    private string rg;
    private string endereco;

    private int idade;

    public Client(string nome, string cpf, string rg, string endereco, int idade)
    {
      this.nome = nome;
      this.cpf = cpf;
      this.rg = rg;
      this.endereco = endereco;
      this.idade = idade;
    }

    public bool maiorDeIdade()
    {
      if (this.idade >= 18)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}