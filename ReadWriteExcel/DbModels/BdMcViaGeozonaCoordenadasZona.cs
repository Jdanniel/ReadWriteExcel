﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdMcViaGeozonaCoordenadasZona
    {
        public int IdGeozonaCoordenadasPlaza { get; set; }
        public int? IdZona { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orden { get; set; }
    }
}
