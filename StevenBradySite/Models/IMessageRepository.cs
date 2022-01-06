using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public interface IMessageRepository
    {
        public List<MessageModel> GetMessages();
        public void AddMessage(MessageModel m);
        public MessageModel FindMessage(int id);
        
    }
}
