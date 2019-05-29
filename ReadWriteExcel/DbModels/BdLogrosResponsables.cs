using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdLogrosResponsables
    {
        public int IdLogrosResponsables { get; set; }
        public int? IdLogro { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdArea { get; set; }
    }
}
