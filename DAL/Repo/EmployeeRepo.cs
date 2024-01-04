using System;
using DAL.Interfaces;
using DAL.Model;
using DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class EmployeeRepo : Repo, IRepo<Employee, int, Employee>
    {
        public EmployeeRepo(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public Employee Create(Employee obj)
        {
            context.Employees.Add(obj);
            return context.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            context.Employees.Remove(obj);
            return context.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            return context.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return context.Employees.FirstOrDefault(c => c.Id == id);
        }

        public Employee Update(Employee obj)
        {
            var existingEmployee = Get(obj.Id);

            if (existingEmployee != null)
            {
                context.Entry(existingEmployee).CurrentValues.SetValues(obj);
                return context.SaveChanges() > 0 ? obj : null;
            }

            return null;
        }
    }

}

