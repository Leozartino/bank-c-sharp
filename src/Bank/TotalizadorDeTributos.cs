namespace Bank
{
  public class TotalizadorDeTributos
  {
    private double total;
    public double Total
    {
      get
      {
        return this.total;
      }
      private set
      {
        this.total = value;
      }
    }

    public void Acumula(ITributavel tributavel)
    {
      this.total += tributavel.calculaTributo();
    }
  }
}