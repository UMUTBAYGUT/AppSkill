using System;
namespace AppSkill.Model.Database
{
    public class SalesChannelSkuRelation : ModelBase
    {
        public SalesChannelSkuRelation()
        {

        }

        public int SalesChannelSkuRelationId { get; set; }
        public int SkuId { get; set; }
        public int SalesChannelId { get; set; }
    }
}
