using System;

namespace Contract
{

    class Ticket
    {
        public int TicketId { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public TicketState TicketState { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        
    }
}