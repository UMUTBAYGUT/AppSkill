﻿using System;
namespace AppSkill.Model.Database
{
    public class LocationSalesChannelRelation : ModelBase
    {
        public LocationSalesChannelRelation()
        {
        }
        public int LocationSalesChannelRelationId { get; set; }
        public int LocationId { get; set; }
        public int SalesChannelId { get; set; }
    }
}
