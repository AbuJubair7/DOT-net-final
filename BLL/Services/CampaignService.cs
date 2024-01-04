using System;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
	public class CampaignService
	{
		public static List<CampaignDTO> Get()
		{
			return Conversion<Campaign, CampaignDTO>.ConvertToList(DataAccessFactory.CampaignData().Get());
		}
        public static CampaignDTO Get(int id)
        {
            
            return Conversion<Campaign, CampaignDTO>.Convert(DataAccessFactory.CampaignData().Get(id));
        }
        public static CampaignDTO Create(CampaignDTO data)
		{
			var mapped = Conversion<CampaignDTO, Campaign>.Convert(data);
			var ret = DataAccessFactory.CampaignData().Create(mapped);

            return Conversion<Campaign, CampaignDTO>.Convert(ret);
        }
		public static CampaignDTO Update(CampaignDTO data)
		{
			var mapped = Conversion<CampaignDTO, Campaign>.Convert(data);
			var ret = DataAccessFactory.CampaignData().Update(mapped);

			return Conversion<Campaign, CampaignDTO>.Convert(ret);
		}
		public static bool Delete(int id)
		{
            return DataAccessFactory.CampaignData().Delete(id);
        }
	}
}

