﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbNModels
{
    public partial class BdOrdenCompraNoFactura
    {
        public int IdOrdenCompraNoFactura { get; set; }
        public int? IdOrdenCompra { get; set; }
        public string NoFactura { get; set; }
        public DateTime? FecFactura { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}