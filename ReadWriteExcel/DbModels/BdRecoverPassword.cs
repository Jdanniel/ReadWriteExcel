﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdRecoverPassword
    {
        public int IdRecoveryPassword { get; set; }
        public int? IdUsuario { get; set; }
        public string TemporaryPassword { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
