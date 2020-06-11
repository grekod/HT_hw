using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HT.API.DAL;
using HT.API.DAL.EF;
using HT.API.DAL.MemoryRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemoryController : ControllerBase
    {
        MemoryBLL _bll;
        public MemoryController(IMemoryRepository repo)
        {
            _bll = new MemoryBLL(repo);
        }

        [HttpPost("post")]
        public async Task<IActionResult> Insert([FromBody] Memory data)
        {
            try
            {
                await _bll.Insert(data);
                return Ok(data);
            }
            catch
            {
                return StatusCode(500);
            }
        }


        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var memo = _bll.GetById(id);
                return Ok(memo);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var memo = _bll.GetAll();
                return Ok(memo);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id,Memory newMemory)
        {
            try
            {
                await _bll.Update(id,newMemory);
                return Ok(_bll.GetById(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut("archive/{id}")]
        public async Task<IActionResult> Archive(int id)
        {
            try
            {
                await _bll.Archive(id);
                return Ok(_bll.GetById(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }


        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _bll.Delete(id);
                return Ok(_bll.GetById(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }

    }
}
