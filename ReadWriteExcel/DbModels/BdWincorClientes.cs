﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdWincorClientes
    {
        public int IdClienteWincor { get; set; }
        public string Nombre { get; set; }
        public int? IdCliente { get; set; }
    }
}
