namespace TddSistemaHospedagem.Domain.Model;

public class Guest
{
  private string _FirstName = "";
  private string _LastName = "";
  private string _Username = "";

  public string FirstName
  {
    get => _FirstName;
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("First name cannot be null or empty");
      }

      _FirstName = value;
    }
  }

  public string LastName
  {
    get => _LastName;
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Last name cannot be null or empty");
      }

      _LastName = value;
    }
  }

  public string FullName
  {
    get
    {
      if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
      {
        throw new ArgumentException("Either FirstName or LastName is null or empty");
      }

      return FirstName + " " + LastName;
    }
  }

  public string Username
  {
    get => _Username;
    set
    {
      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException("Username cannot be null or empty");
      }

      if (value.Length < 3)
      {
        throw new ArgumentException("Username must have at least 3 characters");
      }

      _Username = value;
    }
  }
}
