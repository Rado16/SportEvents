using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEvents
{
    internal class SportEvent
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public int TicketsAvailable { get; set; }
        public double Price { get; set; }
        public SportEvent(int eventID, string name, string location, string date, int ticketsAvailable, double price)
        {
            EventID = eventID;
            Name = name;
            Location = location;
            Date = date;
            TicketsAvailable = ticketsAvailable;
            Price = price;
        }
    }
}
