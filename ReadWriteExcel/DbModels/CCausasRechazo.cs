using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class CCausasRechazo
    {
        public CCausasRechazo()
        {
            BdAr = new HashSet<BdAr>();
        }

        public int IdCausaRechazo { get; set; }
        public string DescCausaRechazo { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string StatusReasonCode { get; set; }

        public virtual ICollection<BdAr> BdAr { get; set; }
    }
}
