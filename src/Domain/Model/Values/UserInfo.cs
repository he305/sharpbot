using Common.Primitives;
using Common.Validators;

namespace Domain.Model.Values;

public class UserInfo : ValueObject
{
    public string Name { get; set; }
    public AnimeListInfo AnimeListInfo{ get; set; }

    public UserInfo(string name, AnimeListInfo animeListInfo) 
    {
        StringValidator.Validate(name);

        Name = name;
        AnimeListInfo = animeListInfo;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Name;
        yield return AnimeListInfo;
    }
}
