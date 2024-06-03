namespace TddSistemaHospedagem.Domain.Model;

public class SuiteTest
{
  [Fact]
  public void CannotSetANegativeCapacity()
  {
    Suite suite = new Suite();
    Assert.Throws<ArgumentException>(() => suite.Capacity = -1);
  }

  [Fact]
  public void CanAssignAValidCapacity()
  {
    Suite suite = new Suite();
    int expected = 2;

    suite.Capacity = 2;

    Assert.Equal(expected, suite.Capacity);
  }

  [Fact]
  public void CannotSetNonPositiveSuiteNumber()
  {
    Suite suite = new Suite();
    Assert.Throws<ArgumentException>(() => suite.Number = 0);
  }

  [Fact]
  public void CanAssignAValidSuiteNumber()
  {
    Suite suite = new Suite();
    int expected = 2;

    suite.Number = 2;

    Assert.Equal(expected, suite.Number);
  }
}
