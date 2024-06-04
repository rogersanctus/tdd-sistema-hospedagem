using System.ComponentModel.DataAnnotations;

namespace TddSistemaHospedagem.Domain.Model;

public class ReservationTest
{
  [Fact]
  public void GivenASuiteAndAtLeastAGuest_WhenCreatingAReservation_ThenModelIsValid()
  {
    Suite suite = new Suite();
    Guest guest = new Guest();

    Reservation reservation = new Reservation(suite);
    reservation.Guests.Add(guest);

    ValidationContext vc = new ValidationContext(reservation);
    var results = new List<ValidationResult>();
    Validator.TryValidateObject(reservation, vc, results, true);

    Assert.True(results.Count() == 0);
  }

  [Fact]
  public void GivenAnInvalidReservationTime_WhenSettingAReservation_ThenModelIsInvalid()
  {
    Suite suite = new Suite();
    Guest guest = new Guest();

    Reservation reservation = new Reservation(suite);

    reservation.Guests.Add(guest);
    reservation.ReservationTime = 0;

    ValidationContext vc = new ValidationContext(reservation);
    var results = new List<ValidationResult>();
    Validator.TryValidateObject(reservation, vc, results, true);

    Assert.Single(results);
  }

  [Fact]
  public void GivenAnInvalidDiscount_WhenSettingAReservation_ThenModelIsInvalid()
  {
    Suite suite = new Suite();
    Guest guest = new Guest();

    Reservation reservation = new Reservation(suite);

    reservation.Guests.Add(guest);
    reservation.Discount = -1;

    ValidationContext vc = new ValidationContext(reservation);
    var results = new List<ValidationResult>();
    Validator.TryValidateObject(reservation, vc, results, true);

    Assert.Single(results);
  }
}
