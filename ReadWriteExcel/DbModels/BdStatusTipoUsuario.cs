using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdStatusTipoUsuario
    {
        public int IdStatusTipoUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public int? IdStatusAr { get; set; }
    }
}
