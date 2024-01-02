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
            Context.Conversions.Add(obj);
            return Context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(string id)
        {
            var obj = Get(id);
            Context.Conversions.Remove(obj);
            return Context.SaveChanges() > 0 ? true : false;
        }

        public List<Conversion> Get()
        {
            return Context.Conversions.ToList();
        }

        public Conversion Get(string id)
        {
            return Context.Conversions.Find(id);
        }

        public Conversion Update(Conversion obj)
        {
            var con = Get(obj.CampaignId.ToString());
            Context.Entry(con).CurrentValues.SetValues(obj);
            return Context.SaveChanges() > 0 ? obj : null;
        }
    }
}

