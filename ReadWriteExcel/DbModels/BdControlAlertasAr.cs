﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdControlAlertasAr
    {
        public int IdControlAr { get; set; }
        public int? IdAr { get; set; }
        public string NoAr { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Avisado { get; set; }
    }
}
