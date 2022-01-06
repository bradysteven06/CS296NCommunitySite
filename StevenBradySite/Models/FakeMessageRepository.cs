using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public class FakeMessageRepository : IMessageRepository
    {
        private List<MessageModel> messageList = new List<MessageModel>();
        private MessageModel message = new MessageModel();

        public void AddMessage(MessageModel m)
        {
            messageList.Add(m);
        }

        public List<MessageModel> GetMessages()
        {
            return messageList;
        }

        public MessageModel FindMessage(int id)
        {
            throw new NotImplementedException();
        }
    }
}
