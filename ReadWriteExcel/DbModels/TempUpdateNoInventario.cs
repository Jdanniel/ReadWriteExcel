﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class TempUpdateNoInventario
    {
        public int IdTempUpdateNoInventario { get; set; }
        public int IdUnidad { get; set; }
        public string NoInventario { get; set; }
    }
}
