using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AviableProductController : ControllerBase
    {
        public static readonly List<AviableProduct> _list = new List<AviableProduct>();
        public static int i = 0;

        // GET: api/<ShoopingListController>
        [HttpGet]
        public List<AviableProduct> Get()
        {
            return _list;
        }

        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult Get(int id)
        {
            AviableProduct tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }
        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] AviableProduct value)
        {
            value.Id = i++;
            _list.Add(value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] AviableProduct value)
        {

            AviableProduct tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            tmp.Name = value.Name;
            tmp.Amount = value.Amount;
            return Ok();

        }

        // DELETE api/<ShoopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            AviableProduct tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();

            _list.Remove(tmp);
            return Ok();

        }
    }
}
