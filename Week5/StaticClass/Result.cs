﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClas
{
    public class Result
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

    }
}
