using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class CampaignRepo : Repo, IRepo<Campaign, string, Campaign>
    {
       
        public CampaignRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Campaign Create(Campaign obj)
        {
            context.Campaigns.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(string id)
        {
            var campagin = Get(id);
            context.Campaigns.Remove(campagin);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Campaign> Get()
        {
            return context.Campaigns.ToList();
        }

        public Campaign Get(string id)
        {
            return context.Campaigns.Find(id);

        }

        public Campaign Update(Campaign obj)
        {
            var camp = Get(obj.Title);
            context.Entry(camp).CurrentValues.SetValues(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }
    }
}

