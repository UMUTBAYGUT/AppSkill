using System;
using System.Collections.Generic;

namespace AppSkill.Model.Service
{
    public class GetAvailabityRequestModal
    {
        public GetAvailabityRequestModal()
        {
        }

        public string salesChannel { get; set; }
        public List<string> sku { get; set; }
    }
}
