using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class Clinics
    {
        public int Id { get; set; }
        public decimal Fees { get; set; }

        public int CountryId { get; set; }

        public string Street { get; set; }

        public int AreaID { get; set; }

        public int CityId { get; set; }
        public DateTime WaitingTime { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int UserId { get; set; }

        public string Logo { get; set; }
        public IEnumerable<Worktime> Worktimes { get; set; } = new List<Worktime>();
        public IEnumerable<ClinicImages> ClinicImages { get; set; } = new List<ClinicImages>();

        public IEnumerable<ClincRate> ClincRates { get; set; } = new List<ClincRate>();
        public ApplicationUser User { get; set; } = null!;


    }
}
