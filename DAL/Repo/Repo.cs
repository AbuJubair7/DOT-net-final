using System;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
	public class Repo
	{
		internal AppDbContext context;
		public Repo(DbContextOptions<AppDbContext> options)
		{
            context = new AppDbContext(options);
		}
	}
}

