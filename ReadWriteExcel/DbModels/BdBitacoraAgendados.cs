﻿using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class BdBitacoraAgendados
    {
        public int IdBitacoraAgendado { get; set; }
        public int IdAr { get; set; }
        public DateTime FecAtencionIni { get; set; }
        public DateTime FecAtencionFin { get; set; }
        public int IdResponsableAgendado { get; set; }
        public string Autorizador { get; set; }
        public string Comentario { get; set; }
        public int? IsVisitaAgendado { get; set; }
        public string FolioTir { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdComentarioAgendado { get; set; }

        public virtual BdAr IdArNavigation { get; set; }
        public virtual CResponsablesAgendados IdResponsableAgendadoNavigation { get; set; }
    }
}
