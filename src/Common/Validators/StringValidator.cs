using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validators;

public class StringValidator
{
    public static void Validate(string  value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new StringValidationException();
        }
    }
}

