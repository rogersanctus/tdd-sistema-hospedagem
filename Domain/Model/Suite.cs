using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TddSistemaHospedagem.Domain.Model;

public class Suite
{
  private int _Capacity;
  private int _Number;
  private decimal _DailyPrice;

  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid Id { get; set; }

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

  [Precision(38, 4)]
  public decimal DailyPrice
  {
    get => _DailyPrice;
    set
    {
      if (value < 0)
      {
        throw new ArgumentException("Daily price cannot be negative");
      }

      _DailyPrice = value;
    }
  }
}
