using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TddSistemaHospedagem.Domain.Validators;

namespace TddSistemaHospedagem.Domain.Model;

public class Reservation /*  : IValidatableObject */
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid Id { get; set; }

  [Required]
  public Suite? Suite { get; set; }

  [Required]
  [Range(1, 30)]
  public int ReservationTime { get; set; }

  [Range(0d, 1d)]
  [Precision(5, 4)]
  public decimal Discount { get; set; }

  [Required]
  [EnsureOneElement]
  public List<Guest> Guests { get; set; }

  public Reservation()
  {
    this.Suite = null;
    this.Discount = 0;
    this.ReservationTime = 1;
    this.Guests = new List<Guest>();
  }
}
