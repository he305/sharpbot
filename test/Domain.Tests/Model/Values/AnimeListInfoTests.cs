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
    public class AnimeListInfoTests
    {
        [Fact()]
        public void AnimeListInfoEmptyNickname()
        {
            string nickname = "";
            string password = "pass";

            Assert.Throws<StringValidationException>(() => new AnimeListInfo(nickname, password));
        }

        [Fact()]
        public void AnimeListInfoEmptyPassword()
        {
            string nickname = "nick";
            string password = "";

            Assert.Throws<StringValidationException>(() => new AnimeListInfo(nickname, password));
        }

        [Fact()]
        public void AnimeListInfoOk()
        {
            string nickname = "nickname";
            string password = "pass";

            var exception = Record.Exception(() => new AnimeListInfo(nickname, password));
            Assert.Null(exception);
        }

        [Fact()]
        public void GetAtomicValuesTest()
        {
            string nickname = "nick";
            string password = "pass";
            var animeListInfo = new AnimeListInfo(nickname, password);

            string[] expected = { nickname, password };

            Assert.True(animeListInfo.GetAtomicValues().Take(2).SequenceEqual(expected));
        }
    }
}