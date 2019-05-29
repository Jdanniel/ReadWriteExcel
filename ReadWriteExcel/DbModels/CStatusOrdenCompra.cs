using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbModels
{
    public partial class CStatusOrdenCompra
    {
        public int IdStatusOrdenCompra { get; set; }
        public string DescStatus { get; set; }
        public string Status { get; set; }
    }
}
