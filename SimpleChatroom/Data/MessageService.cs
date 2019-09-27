using System;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleChatroom.Data
{
    public class MessageService
    {
        public delegate void NewChatHandler(ChatMessage e);
        public event NewChatHandler NewChat;

        public void sendNewMessage(ChatMessage msg)
        {
            NewChat?.Invoke(msg);
        }
    }

    public class ChatMessage
    {
        public string Name;
        public DateTime Timestamp;
        public string Message;
    }
}
