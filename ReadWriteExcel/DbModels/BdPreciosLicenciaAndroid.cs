using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdPreciosLicenciaAndroid
    {
        public int IdPrecioLicencia { get; set; }
        public string RangoLicencia { get; set; }
        public decimal? CostoMensual { get; set; }
    }
}
