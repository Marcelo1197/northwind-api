using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Domain.Models.Shipper.Request;
using NorthwindAPI.Domain.Models.Shipper.Response;
using NorthwindAPI.Logic;

namespace NorthwindAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipperController : ControllerBase
    {
        private ShipperLogic _logic = new ShipperLogic();

        [HttpGet]
        [Route("shippers/{id}")]
        public async Task<ActionResult<ResponseShipper>> Get(int id) {
            if (ModelState.IsValid)
            {
                var shipperFound = _logic.Get(id);
                return Ok(shipperFound);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("shippers")]
        public async Task<ActionResult<List<ResponseShipper>>> GetAll()
        {
            if (ModelState.IsValid)
            {
                var shippersList = _logic.GetAll();
                return Ok(shippersList);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("shipper")]
        public async Task<ActionResult<ResponseShipper>> Add([FromBody] RequestAddShipper shipper)
        {
            if (ModelState.IsValid)
            {
                _logic.Add(shipper);
                return Ok(shipper);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("shipper/edit")]
        public async Task<ActionResult<ResponseShipper>> Edit([FromBody] RequestEditShipper shipper)
        {
            if (ModelState.IsValid)
            {
                _logic.Update(shipper);
                return Ok(shipper);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
