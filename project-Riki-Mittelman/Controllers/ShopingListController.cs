﻿using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopingListController : ControllerBase
    {
        public static readonly List<ShopingList> _list = new List<ShopingList>();
        public static int i = 0;

        // GET: api/<ShoopingListController>
        [HttpGet]
        public List<ShopingList> Get()
        {
            return _list;
        }

        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult Get(int id)
        {
            ShopingList tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }
        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] ShopingList value)
        {
            value.Id = i++;
            _list.Add(value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ShopingList value)
        {

            ShopingList tmp;
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

            ShopingList tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();

            _list.Remove(tmp);
            return Ok();

        }
    }
}
