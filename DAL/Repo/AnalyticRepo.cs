using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class AnalyticRepo : Repo, IRepo<Analytic, int, Analytic>
    {
        public AnalyticRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Analytic Create(Analytic obj)
        {
            context.Analytics.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            context.Analytics.Remove(obj);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Analytic> Get()
        {
            return context.Analytics.ToList();
        }

        public Analytic Get(int id)
        {
            return context.Analytics.FirstOrDefault((c => c.ID == id));
        }

        public Analytic Update(Analytic obj)
        {
            var con = Get(obj.ID);
            context.Entry(con).CurrentValues.SetValues(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }
    }
}

