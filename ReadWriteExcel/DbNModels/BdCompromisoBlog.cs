﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbNModels
{
    public partial class BdCompromisoBlog
    {
        public int IdCompromisosBlog { get; set; }
        public int? IdCompromiso { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Comentario { get; set; }
    }
}