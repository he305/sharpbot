using Xunit;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Values;

namespace Domain.Model.Tests
{
    public class UserTests
    {
        [Fact()]
        public void UserTestNew()
        {
            UserInfo userInfo = new UserInfo("s", new AnimeListInfo("s", "s"));
            ChatInfo chatInfo = new ChatInfo("s");

            User first = new User(userInfo, chatInfo);
            User second = new User(userInfo, chatInfo);

            Assert.NotEqual(first, second);
        }

        [Fact()]
        public void UserTestExistent()
        {
            Guid id = Guid.NewGuid();
            UserInfo userInfo = new UserInfo("s", new AnimeListInfo("s", "s"));
            ChatInfo chatInfo = new ChatInfo("s");

            User first = new User(id, userInfo, chatInfo);
            User second = new User(id, userInfo, chatInfo);

            Assert.Equal(first, second);
        }
    }
}