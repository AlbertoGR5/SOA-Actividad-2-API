﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ActivoRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    }
}
