using Common.Primitives;
using Domain.Model.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;
public class User : AggregateRoot
{
    public UserInfo UserInfo { get; set; }
    public ChatInfo ChatInfo { get; set; }

    public User(Guid id, UserInfo userInfo, ChatInfo chatInfo) : base(id)
    {
        UserInfo = userInfo;
        ChatInfo = chatInfo;
    }

    public User(UserInfo userInfo, ChatInfo chatInfo)
        :base(Guid.NewGuid())
    {
        UserInfo = userInfo;
        ChatInfo = chatInfo;
    }
}

