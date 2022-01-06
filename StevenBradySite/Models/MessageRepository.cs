using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public class MessageRepository : IMessageRepository
    {
        private MessageContext message { get; set; }

        public MessageRepository(MessageContext context)
        {
            message = context;
        }

        public List<MessageModel> GetMessages()
        {
            return message.Messages.ToList();
        }

        public void AddMessage(MessageModel m)
        {
            message.Messages.Add(m);
            message.SaveChanges();
        }

        public MessageModel FindMessage(int id)
        {
            throw new NotImplementedException();
        }
    }
}
