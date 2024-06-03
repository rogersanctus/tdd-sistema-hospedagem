namespace TddSistemaHospedagem.Domain.Model;

public class Guest
{
  private string _FirstName = "";
  private string _LastName = "";

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
}
