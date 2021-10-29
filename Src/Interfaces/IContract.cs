using System;
using System.Collections.Generic;
using Contract;

namespace Name
{
    interface IContract
    {
        /// Returns an Array of Tickets, given the provided DataSource
        public Ticket[] GetTickets(ITicketDataService TicketDs);

        /// Returns an Array of Employees, given the provided DataSource
        public Employee[] GetEmployees(IEmployeeDataService EmpDs);

        // Input Expects an ticket with messages, that is not null
        // Needs to return Average response time of messages, meaning how much time did pass until an Employee answered
        // If the last message has no response yet, the calculation for that response time should take the current time
        // Returns a timespan struct  
        public TimeSpan GetAverageResponseTime(Ticket ticket);

        // A Closed ticket is in state "Closed"
        // Start day is the employees first ticket ever, on the daythe first message was send.
        // Float need to have two decimals for further processing
        public float GetAverageDailyTicketsClosed(Employee emp);

        // The provided list should be only be linked list given the timestamp, with oldest first
        public LinkedList<Message> GetConversation(Ticket ticket);

        // The provided list should be only be linked list given the timestamp, with oldest first
        // The tickets input can be a mix of multiple employees
        // Unassigned(Meaning to employee) tickets should be filtered out
        public Dictionary<Employee, LinkedList<Ticket>> GetConversations(Ticket[] tickets);
    }
}