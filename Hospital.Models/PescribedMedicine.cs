using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class PescribedMedicine
    {
        public int id { get; set; }
        public Medicine Medicine { get; set; }
        public PatientReport PatientReport { get; set; }
    }
}
