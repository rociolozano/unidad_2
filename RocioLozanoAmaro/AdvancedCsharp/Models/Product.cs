﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedCsharp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float price { get; set; }
        public string category { get; set; }

    }
}