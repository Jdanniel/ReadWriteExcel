using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWriteExcel.Models
{
    public class Response
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public int Data { get; set; }

        //public T Data { get; set; }

        public static Response GetResult(int code, string msg, int data)
        {
            return new Response
            {
                Code = code,
                Msg = msg,
                Data = data
            };
        }
    }
}
