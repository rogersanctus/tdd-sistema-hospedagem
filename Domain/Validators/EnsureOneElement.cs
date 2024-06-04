using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TddSistemaHospedagem.Domain.Validators;

public class EnsureOneElement : ValidationAttribute
{
  public override bool IsValid(object? value)
  {
    var list = value as IList;

    if (list != null)
    {
      return list.Count > 0;
    }

    return false;
  }
}
