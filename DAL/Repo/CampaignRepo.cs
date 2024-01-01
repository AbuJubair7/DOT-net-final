using System;
using DAL.Interfaces;
using DAL.Model.Entity;

namespace DAL.Repo
{
    public class CampaignRepo : Repo, IRepo<Campaign, String, Campaign>
    {
        public Campaign Create(Campaign obj)
        {
            Context.Campaigns.Add(obj);
            return Context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(string id)
        {
            var campagin = Get(id);
            Context.Campaigns.Remove(campagin);
            return Context.SaveChanges() > 0 ? true : false;
        }

        public List<Campaign> Get()
        {
            return Context.Campaigns.ToList();
        }

        public Campaign Get(string id)
        {
            return Context.Campaigns.Find(id);

        }

        public Campaign Update(Campaign obj)
        {
            var camp = Get(obj.Title);
            Context.Entry(camp).CurrentValues.SetValues(obj);
            return Context.SaveChanges() > 0 ? obj : null;
        }
    }
}

