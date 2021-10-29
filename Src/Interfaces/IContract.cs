using System;
using System.Collections.Generic;
using Contract;

namespace Name
{
    interface IContract
    {
        public Ticket[] GetTickets(ITicketDataService TickDs);
        public Employee[] GetEmployees(IEmployeeDataService EmpDs);

        public TimeSpan GetAverageResponseTime(Ticket[] tickets);
        public float GetAverageDailyTicketsClosed(Employee emp);

        public LinkedList<Message> GetConversation(Ticket ticket);

        public Dictionary<Employee, LinkedList<Ticket>> GetConversations(Ticket[] tickets);

    }
}