﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLibrary.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
