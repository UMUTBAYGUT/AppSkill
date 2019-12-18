using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSkill.Core.Repository;
using AppSkill.Model.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppSkill.Backend.Controllers.v1
{
    [Route("v1/[controller]")]
    public class GetAvailablityController : Controller
    {
        private readonly SalesChannelRepository _salesChannelRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ISkuRepository _skuRepository;
        private readonly ISalesChannelSkuRelationRepository _salesChannelSkuRelationRepository;
        private readonly ILocationSalesChannelRelationRepository _locationSalesChannelRelationRepository;

        public GetAvailablityController(ILocationRepository locationRepository,SalesChannelRepository salesChannelRepository, ISkuRepository skuRepository,ISalesChannelSkuRelationRepository salesChannelSkuRelationRepository,ILocationSalesChannelRelationRepository locationSalesChannelRelationRepository)
        {
            _locationRepository = locationRepository;
            _salesChannelRepository = salesChannelRepository;
            _skuRepository = skuRepository;
            _salesChannelSkuRelationRepository = salesChannelSkuRelationRepository;
            _locationSalesChannelRelationRepository = locationSalesChannelRelationRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get(GetAvailabityRequestModal _object)
        {
            //TODO control parametres for null or space

            foreach (var sku in _object.sku)
            {
                var dbSku = _skuRepository.Get(x => x.Title == sku);
                //TODO null check
                var salesChannelIds = _salesChannelSkuRelationRepository.GetMany(x => x.SkuId == dbSku.SkuId);
                //TODO null check

            }

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
