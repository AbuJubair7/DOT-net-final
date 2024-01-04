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
    [Route("employee")]
    public class EmployeeController : Controller
    {
        // GET: employee
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = EmployeeService.Get();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // GET: employee/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var data = EmployeeService.Get(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST: employee
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeDTO data)
        {
            try
            {
                var ret = EmployeeService.Create(data);
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

        // PATCH: employee
        [HttpPatch]
        public IActionResult Patch([FromBody] EmployeeDTO data)
        {
            try
            {
                var ret = EmployeeService.Update(data);
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

        // DELETE: employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool ret = EmployeeService.Delete(id);
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

