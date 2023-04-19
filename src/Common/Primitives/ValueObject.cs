using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Common.Primitives;
public abstract class ValueObject : IEquatable<ValueObject>
{
    protected ValueObject() { }

    public abstract IEnumerable<object> GetAtomicValues();

    public override bool Equals(object? obj)
    {
        return Equals(obj as ValueObject);
    }

    public override int GetHashCode()
    {
        return GetAtomicValues()
            .Aggregate(default(int), HashCode.Combine);
    }

    private bool ValuesAreEqual(ValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }

    public bool Equals(ValueObject? other)
    {
        return other is not null && ValuesAreEqual(other);
    }
}

