﻿using System;
using System.Collections.Generic;

namespace Domain1.Models
{
    public partial class ProductSpecification
    {
        public int? ProductId { get; set; }
        public int? SpecificationId { get; set; }
        public int? Value { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Specification? Specification { get; set; }
    }
}
