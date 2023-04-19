using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.Primitives;

namespace Common.Exceptions;
public class StringValidationException : DomainException
{
    public StringValidationException() 
        : base("String is null or empty")
    {

    }
}

