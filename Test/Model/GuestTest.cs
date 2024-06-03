namespace TddSistemaHospedagem.Domain.Model;

public class GuestTest
{
  [Fact]
  public void CannotAssignAnEmptyFirstName()
  {
    Guest guest = new Guest();
    string emptyName = "";

    Assert.Throws<ArgumentException>(() => guest.FirstName = emptyName);
  }

  [Fact]
  public void CanAssignAValidFirstName()
  {
    Guest guest = new Guest();
    string expectedName = "John";

    guest.FirstName = expectedName;

    Assert.Equal(expectedName, guest.FirstName);
  }

  [Fact]
  public void CannotAssignAnEmptyLastName()
  {
    Guest guest = new Guest();
    string emptyName = "";

    Assert.Throws<ArgumentException>(() => guest.LastName = emptyName);
  }

  [Fact]
  public void CanAssignAValidLastName()
  {
    Guest guest = new Guest();
    string expectedName = "Doe";

    guest.LastName = expectedName;

    Assert.Equal(expectedName, guest.LastName);
  }
}
