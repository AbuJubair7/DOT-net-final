using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class ConversionRepo : Repo, IRepo<Conversion, int, Conversion>
    {
        public ConversionRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Conversion Create(Conversion obj)
        {
            context.Conversions.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            context.Conversions.Remove(obj);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Conversion> Get()
        {
            return context.Conversions.ToList();
        }

        public Conversion Get(int id)
        {
            return context.Conversions.FirstOrDefault((c => c.ID == id));
        }

        public Conversion Update(Conversion obj)
        {
            var con = Get(obj.ID);
            context.Entry(con).CurrentValues.SetValues(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }
    }
}

