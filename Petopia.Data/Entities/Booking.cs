using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int WorktimeId { get; set; }

        public Worktime Worktimes { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

    }
}
