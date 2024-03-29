﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppLayer.Controllers
{

    [Controller]
    [Route("campaign")]
    public class CampaignController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = CampaignService.Get();
                return Ok(data);
            }
            catch(Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            try
            {
                var data = CampaignService.Get(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CampaignDTO data)
        {
            Console.WriteLine(data.Title);
            Console.WriteLine(data.Status);
            Console.WriteLine(data.TotalSent);
            try
            {
                data.AnalyticId = 0;
                data.Date = DateTime.UtcNow;
                var analytic = new AnalyticDTO
                {
                    NewLeadRate = 0,
                    ClosedWonRate = 0,
                    ClosedLostRate = 0
                };
                var newAna = AnalyticService.Create(analytic);
                if (newAna != null)
                {
                    data.AnalyticId = newAna.ID;
                    var ret = CampaignService.Create(data);
                    if (ret != null)
                    {
                        return Ok("Success");
                    }
                    else
                    {
                        return StatusCode(500, $"Creation at server error");
                    }
                }
                else
                {
                    return StatusCode(500, $"Creation at server error");
                }
                    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // PUT api/values/5
        [HttpPatch]
        public IActionResult Put([FromBody]CampaignDTO data)
        {
            try
            {
                data.Date = DateTime.UtcNow;
                var ret = CampaignService.Update(data);
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

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool ret = CampaignService.Delete(id);
                if (ret)
                {
                    return Ok("Deleted");
                } else
                {
                    throw new Exception("Error on Deleting");
                }
            }
            catch(Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}

