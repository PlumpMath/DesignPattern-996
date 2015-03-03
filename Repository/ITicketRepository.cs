using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetTickets();
        void AddTicket(Ticket ticket);

    }
}
