using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbNModels
{
    public partial class CTipoSparePart
    {
        public CTipoSparePart()
        {
            CSpareParts = new HashSet<CSpareParts>();
        }

        public int IdTipoSparePart { get; set; }
        public string DescTipoSparePart { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CSpareParts> CSpareParts { get; set; }
    }
}
