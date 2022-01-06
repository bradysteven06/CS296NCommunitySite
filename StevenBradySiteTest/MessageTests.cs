using System;
using Xunit;
using StevenBradySite.Models;
using StevenBradySite.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;

namespace StevenBradySiteTest
{
    public class MessageTests
    {
        [Fact]
        public void GetMessageTest()
        {
            IMessageRepository rep = new FakeMessageRepository();
            MessageModel model = new MessageModel();
            List<MessageModel> messageList = new List<MessageModel>();

            model.MessageId = 0;
            model.FirstName = "D";
            model.LastName = "Pool";
            model.Date = "11-28-21";
            model.Message = "I'M Batman";

            // adds message to repository
            rep.AddMessage(model);

            // gets message/messages from repository and puts in list
            messageList = rep.GetMessages();

            // checks values of message
            Assert.Equal(0, messageList[0].MessageId);
            Assert.Equal("D", messageList[0].FirstName);
            Assert.Equal("Pool", messageList[0].LastName);
            Assert.Equal("11-28-21", messageList[0].Date);
            Assert.Equal("I'M Batman", messageList[0].Message);

        }

        [Fact]
        public void AddMessageTest()
        {
            IMessageRepository rep = new FakeMessageRepository();
            MessageModel model = new MessageModel();

            model.MessageId = 0;
            model.FirstName = "D";
            model.LastName = "Pool";
            model.Date = "11-28-21";
            model.Message = "I'M Batman";

            // adds message to repository
            rep.AddMessage(model);

            // asserts that one message is in repository
            Assert.True(1 == rep.GetMessages().Count);
        }

        
    }
}
