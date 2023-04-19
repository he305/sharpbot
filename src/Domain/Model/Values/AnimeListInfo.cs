using Common.Primitives;
using Common.Validators;

namespace Domain.Model.Values;
public class AnimeListInfo : ValueObject
{
    public string Nickname { get; set; }
    public string Password { get; set; }

    public AnimeListInfo(string nickname, string password) 
    {
        StringValidator.Validate(nickname);
        StringValidator.Validate(password);

        Nickname = nickname;
        Password = password;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Nickname;
        yield return Password;
    }
}
