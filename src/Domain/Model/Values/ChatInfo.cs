using Common.Validators;

namespace Domain.Model.Values;
public class ChatInfo
{
    public string ChatId { get; set; }

    public ChatInfo(string chatId)
    {
        StringValidator.Validate(chatId);

        ChatId = chatId;
    }
}
