using System;
using System.Collections.Generic;

namespace AppSkill.DAL.Model
{
    public class SalesChannel
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public List<Sku> Skus { get; set; }
    }
}
