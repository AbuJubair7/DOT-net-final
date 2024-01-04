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
    [Route("report")]
    public class ReportController : Controller
    {
        // GET: report
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = ReportService.Get();
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // GET: report/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var data = ReportService.Get(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST: report
        [HttpPost]
        public IActionResult Post([FromBody] ReportDTO data)
        {
            try
            {
                data.StartDate = DateTime.UtcNow;
                data.EndDate = DateTime.UtcNow;
                var ret = ReportService.Create(data);
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

        // PATCH: report
        [HttpPatch]
        public IActionResult Patch([FromBody] ReportDTO data)
        {
            try
            {
                var ret = ReportService.Update(data);
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

        // DELETE: report/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool ret = ReportService.Delete(id);
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


