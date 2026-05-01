using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_EF03
{
    public class Badge
    {
        public int Id { get; set; }

        public string BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public string Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }
}
