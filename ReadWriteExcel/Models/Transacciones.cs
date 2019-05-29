using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWriteExcel.Models
{
    public class Transacciones
    {
        public string ExternalMID { get; set; }
        public string ApprovedCount { get; set; }
        public string DeclinedCount { get; set; }

    }
}
