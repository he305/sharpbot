using Xunit;
using Domain.Model.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions;

namespace Domain.Model.Values.Tests
{
    public class UserInfoTests
    {
        [Fact()]
        public void UserInfoNameEmpty()
        {
            string name = "";
            AnimeListInfo animeListInfo = new AnimeListInfo("s", "s");

            Assert.Throws<StringValidationException>(() => new UserInfo(name, animeListInfo));
        }

        [Fact()]
        public void UserInfoOk()
        {
            string name = "name";
            AnimeListInfo animeListInfo = new AnimeListInfo("s", "s");

            var exception = Record.Exception(() => new UserInfo(name, animeListInfo));
            Assert.Null(exception);
        }

        [Fact()]
        public void GetAtomicValuesTest()
        {
            string name = "name";
            AnimeListInfo animeListInfo = new AnimeListInfo("s", "s");
            UserInfo userInfo = new UserInfo(name, animeListInfo);

            object[] expected = { name, animeListInfo};

            Assert.True(userInfo.GetAtomicValues().Take(2).SequenceEqual(expected));
        }
    }
}