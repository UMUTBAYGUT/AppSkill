using System;
using System.Collections.Generic;

namespace AppSkill.Model.Database
{
    public class Sku : ModelBase
    {
        public int SkuId { get; set; }
        public string Title { get; set; }
        public int LocationId { get; set; }
        public int Quantity { get; set; }
    }
}
