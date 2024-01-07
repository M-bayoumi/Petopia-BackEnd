using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Worktime
    {
        public int Id { get; set; }

        public int ClincId { get; set; }

        public string Day { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Clinics Clinics { get; set; } = null!;

        public Booking Bookings { get; set; } = null!;
    }
}
