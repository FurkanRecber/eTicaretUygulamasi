﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Application.RequestParameter
{
    public record Pagination
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        
    }
}
