namespace Common.Primitives;
public abstract class Entity : IEquatable<Entity>   
{
    protected Entity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; private init; }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Entity);
    }

    public static bool operator ==(Entity? first, Entity? second)
    {
        return first is not null && second is not null && first.Equals(second);
    }

    public static bool operator !=(Entity? first , Entity? second)
    {
        return !(first == second);
    }

    public bool Equals(Entity? other)
    {
        if (other  == null) return false;

        if (other.GetType() != GetType()) return false;

        return other.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

