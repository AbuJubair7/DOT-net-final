using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class ConversionRepo : Repo, IRepo<Conversion, string, Conversion>
    {
        public ConversionRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Conversion Create(Conversion obj)
        {
            context.Conversions.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(string id)
        {
            var obj = Get(id);
            context.Conversions.Remove(obj);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Conversion> Get()
        {
            return context.Conversions.ToList();
        }

        public Conversion Get(string id)
        {
            return context.Conversions.Find(id);
        }

        public Conversion Update(Conversion obj)
        {
            var con = Get(obj.CampaignId.ToString());
            context.Entry(con).CurrentValues.SetValues(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }
    }
}

