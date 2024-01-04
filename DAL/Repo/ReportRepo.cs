using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class ReportRepo : Repo, IRepo<Report, int, Report>
    {
        public ReportRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Report Create(Report obj)
        {
            context.Reports.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            context.Reports.Remove(obj);
            return context.SaveChanges() > 0;
        }

        public List<Report> Get()
        {
            return context.Reports.ToList();
        }

        public Report Get(int id)
        {
            return context.Reports.FirstOrDefault(c => c.Id == id);
        }

        public Report Update(Report obj)
        {
            var existingReport = Get(obj.Id);

            if (existingReport != null)
            {
                context.Entry(existingReport).CurrentValues.SetValues(obj);
                return context.SaveChanges() > 0 ? obj : null;
            }

            return null;
        }
    }

}

