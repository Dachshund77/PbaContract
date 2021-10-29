namespace Contract
{
    using System;
    using System.Collections.Generic;

    public class MockTicketDataService : ITicketDataService
    {
        public Ticket[] GetTickets()
        {
            return new Ticket[]{
                new Ticket{
                    TicketId = 1, 
                    Topic= "TestTicket", 
                    Description="My cat ran away", 
                    TicketState = TicketState.Closed, 
                    DueDate = new DateTime(2020,2,3,12,50,2), 
                    Customer = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},
                    Employee = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},
                    Messages = new List<Message>(){
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,3,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,4,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,5,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,6,12,51,2)}
                    } 
                },
                new Ticket{
                    TicketId = 2, 
                    Topic= "TestTicket2", 
                    Description="My cat ran away2", 
                    TicketState = TicketState.Open, 
                    DueDate = new DateTime(2021,2,3,12,50,2), 
                    Customer = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},
                    Employee = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},
                    Messages = new List<Message>(){
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,3,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,4,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,5,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,6,12,51,2)}
                    } 
                },
                new Ticket{
                    TicketId = 4, 
                    Topic= "TestTicket4", 
                    Description="My dog ran away", 
                    TicketState = TicketState.Closed, 
                    DueDate = new DateTime(2020,2,3,12,50,2), 
                    Customer = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},
                    Employee = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},
                    Messages = new List<Message>(){
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,3,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,4,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,5,12,51,2)},
                        new Message{TicketId = 1, MessageId= 12411241, SendBy = new Customer{UserId = 442, CustomerId = 11245, Name = "Mette Petersen", Address = "Løngang"},Content = "Why is my cat gone?" , SendAt = new DateTime(2019,2,6,12,51,2)}
                    } 
                }       
            };
        }
    }
}
