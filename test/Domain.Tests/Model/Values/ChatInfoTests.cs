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
    public class ChatInfoTests
    {
        [Fact()]
        public void ChatInfoChatIdEmpty()
        {
            string chatId = "";

            Assert.Throws<StringValidationException>(() => new ChatInfo(chatId));
        }

        [Fact()]
        public void ChatInfoOk() 
        {
            string chatId = "some";

            var exception = Record.Exception(() => new ChatInfo(chatId));
            Assert.Null(exception);
        }
    }
}