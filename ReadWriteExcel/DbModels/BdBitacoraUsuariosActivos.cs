﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdBitacoraUsuariosActivos
    {
        public int IdBitacoraUsuariosActivos { get; set; }
        public int? UsuariosActivosWeb { get; set; }
        public int? UsuariosActivosPda { get; set; }
        public int? TotalUsuariosActivos { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
