using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdFestivos
    {
        public int IdFestivos { get; set; }
        public DateTime? Dia { get; set; }
    }
}
