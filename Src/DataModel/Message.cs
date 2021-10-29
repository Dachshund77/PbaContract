using System;

namespace Contract
{
    class Message
    {
        public int MessageId { get; set; }
        public int TicketId { get; set; }
        public DateTime SendAt { get; set; }
        public User SendBy { get; set; }
        public string Content { get; set; }
    }
}