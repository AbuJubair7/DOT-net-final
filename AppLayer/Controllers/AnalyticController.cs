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
    [Route("analytic")]
    public class AnalyticController : Controller
    {
        // GET: analytic
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = AnalyticService.Get();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // GET: analytic/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var data = AnalyticService.Get(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST: analytic
        [HttpPost]
        public IActionResult Post([FromBody] AnalyticDTO data)
        {
            Console.WriteLine("Inside analytic");
            try
            {
                var ret = AnalyticService.Create(data);
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

        // PATCH: analytic
        [HttpPatch]
        public IActionResult Patch([FromBody] AnalyticDTO data)
        {
            try
            {
                var ret = AnalyticService.Update(data);
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

        // DELETE: analytic/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool ret = AnalyticService.Delete(id);
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

