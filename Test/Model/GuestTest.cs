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

  [Fact]
  public void CannotRetrieveFullNameWhenFirstNameOrLastNameIsEmpty()
  {
    Guest guest = new Guest();

    Assert.Throws<ArgumentException>(() => guest.FullName);
  }

  [Fact]
  public void CanRetrieveFullNameProperly()
  {
    Guest guest = new Guest();
    string expectedFullName = "John Doe";

    guest.FirstName = "John";
    guest.LastName = "Doe";

    Assert.Equal(expectedFullName, guest.FullName);
  }

  [Fact]
  public void CannotAssignAUsernameWithLessThanThreeCharacters()
  {
    Guest guest = new Guest();
    string userName = "gu";

    Assert.Throws<ArgumentException>(() => guest.Username = userName);
  }

  [Fact]
  public void CannotAssignAnEmptyUsername()
  {
    Guest guest = new Guest();
    string userName = "";

    Assert.Throws<ArgumentException>(() => guest.Username = userName);
  }

  [Fact]
  public void CanAssignAValidUsername()
  {
    Guest guest = new Guest();
    string expectedUserName = "guest";

    guest.Username = expectedUserName;

    Assert.Equal(expectedUserName, guest.Username);
  }
}
