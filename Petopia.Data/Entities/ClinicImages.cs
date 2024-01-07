using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petopia.Data.Entities
{
    public class ClinicImages
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ClinicId { get; set; }

        public Clinics Clinics { get; set; } = null!;

    }
}
