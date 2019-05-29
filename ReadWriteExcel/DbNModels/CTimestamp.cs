using System;
using System.Collections.Generic;

namespace ReadWriteExcel.DbNModels
{
    public partial class CTimestamp
    {
        public int IdTimestamp { get; set; }
        public string DescTimestamp { get; set; }
        public string Timestamp { get; set; }
        public string Status { get; set; }
    }
}
