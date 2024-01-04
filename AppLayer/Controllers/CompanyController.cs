using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppLayer.Controllers
{
    [Controller]
    [Route("company")]
    public class CompanyController : Controller
    {
        // GET: company
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = CompanyService.Get();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // GET: company/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var data = CompanyService.Get(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST: company
        [HttpPost]
        public IActionResult Post([FromBody] CompanyDTO data)
        {
            try
            {
                var ret = CompanyService.Create(data);
                if (ret != null)
                {
                    return Ok("Success");
                }
                else
                {
                    return StatusCode(500, $"Creation at server error");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // PATCH: company
        [HttpPatch]
        public IActionResult Patch([FromBody] CompanyDTO data)
        {
            try
            {
                var ret = CompanyService.Update(data);
                if (ret != null)
                {
                    return Ok("Success");
                }
                else
                {
                    return StatusCode(500, $"Internal server error");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // DELETE: company/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool ret = CompanyService.Delete(id);
                if (ret)
                {
                    return Ok("Deleted");
                }
                else
                {
                    throw new Exception("Error on Deleting");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }

}

