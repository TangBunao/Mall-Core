using Mall.IRepository;
using Mall.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mall.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PmsProductController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public PmsProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductCategory([FromBody] PmsProductCategory productCategory)
        {
            _unitOfWork.PmsProductCategoryRepo.Create(productCategory);
            await _unitOfWork.SaveAsync();
            return Ok();
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
