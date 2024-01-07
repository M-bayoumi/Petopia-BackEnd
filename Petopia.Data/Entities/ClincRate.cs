using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class ClincRate
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public decimal Rate { get; set; }

       
        public ApplicationUser User { get; set; } = null!;
        public Clinics Clinics { get; set; } = null!;
    }
}
