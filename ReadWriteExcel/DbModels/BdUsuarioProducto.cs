﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdUsuarioProducto
    {
        public int IdUsuarioProducto { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
