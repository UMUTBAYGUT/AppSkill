using System;
using System.Collections.Generic;

namespace AppSkill.DAL.Model
{
    public class Sku
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public List<SalesChannel> SalesChannels { get; set; }
    }
}
