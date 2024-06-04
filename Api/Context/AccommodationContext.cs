using Microsoft.EntityFrameworkCore;
using TddSistemaHospedagem.Domain.Model;

namespace TddSistemaHospedagem.Api.Context;

public class AccommodationContext : DbContext
{
  public AccommodationContext(DbContextOptions<AccommodationContext> options)
    : base(options) { }

  public DbSet<Suite> Suites { get; set; }
  public DbSet<Guest> Guests { get; set; }
  public DbSet<Reservation> Reservations { get; set; }
}
