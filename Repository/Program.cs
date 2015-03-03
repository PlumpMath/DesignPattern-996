using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            ITicketRepository repo = new TicketRepository();
            foreach (var item in repo.GetTickets())
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
