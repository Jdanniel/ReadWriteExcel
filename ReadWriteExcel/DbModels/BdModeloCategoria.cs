using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdModeloCategoria
    {
        public int IdModeloCategoria { get; set; }
        public int? IdModelo { get; set; }
        public int? IdCategoria { get; set; }
    }
}
