namespace TddSistemaHospedagem.Domain.Model;

public class Suite
{
  private int _Capacity;
  private int _Number;

  public int Number
  {
    get => _Number;
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Number must be a positive number");
      }

      _Number = value;
    }
  }

  public int Capacity
  {
    get => _Capacity;
    set
    {
      if (value < 0)
      {
        throw new ArgumentException("Capacity cannot be negative");
      }

      _Capacity = value;
    }
  }
}
