using System;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
	public class CampaignService
	{
		public List<CampaignDTO> Get()
		{
			var data = DataAccessFactory.CampaignData().Get();
			var cfg = new MapperConfiguration(c =>
			{
				c.CreateMap<Campaign, CampaignDTO>();
			});
			var mapper = new Mapper(cfg);
			var mapped = mapper.Map<List<CampaignDTO>>(data);
			return mapped;
		}
	}
}

