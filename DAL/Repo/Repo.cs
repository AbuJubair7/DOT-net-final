using System;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
	public class Repo
	{
		internal AppDbContext Context;
		public Repo(DbContextOptions<AppDbContext> options)
		{
			Context = new AppDbContext(options);
		}
	}
}

