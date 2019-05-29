using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdHistoricoPassword
    {
        public int IdHistoricoPassword { get; set; }
        public int IdUsuario { get; set; }
        public string Password { get; set; }
        public DateTime FecAlta { get; set; }
    }
}
