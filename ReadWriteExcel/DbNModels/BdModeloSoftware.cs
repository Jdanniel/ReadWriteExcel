﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbNModels
{
    public partial class BdModeloSoftware
    {
        public int IdModeloSoftware { get; set; }
        public int? IdModelo { get; set; }
        public int? IdSoftware { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
