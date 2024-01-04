using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class CompanyRepo : Repo, IRepo<Company, int, Company>
    {
        public CompanyRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Company Create(Company obj)
        {
            context.Companies.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            context.Companies.Remove(obj);
            return context.SaveChanges() > 0;
        }

        public List<Company> Get()
        {
            return context.Companies.ToList();
        }

        public Company Get(int id)
        {
            return context.Companies.FirstOrDefault(c => c.Id == id);
        }

        public Company Update(Company obj)
        {
            var existingCompany = Get(obj.Id);

            if (existingCompany != null)
            {
                context.Entry(existingCompany).CurrentValues.SetValues(obj);
                return context.SaveChanges() > 0 ? obj : null;
            }

            return null;
        }
    }

}

