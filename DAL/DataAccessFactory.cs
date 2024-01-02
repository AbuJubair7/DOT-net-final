
using DAL.Model.Entity;
using DAL.Interfaces;
using DAL.Repo;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DataAccessFactory
{
    internal static string CONNECTION_STRING = "Host=localhost;Port=5432;Database=ASP;Username=postgres;Password=7777;";
    public static IRepo<Campaign, string, Campaign>  CampaignData ()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(DataAccessFactory.CONNECTION_STRING);
        return new CampaignRepo(optionsBuilder.Options);
    }
    public static IRepo<Conversion, string, Conversion> ConversionData()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(DataAccessFactory.CONNECTION_STRING);
        return new ConversionRepo(optionsBuilder.Options);
    }
    private DbContextOptions<AppDbContext> createOptions()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(DataAccessFactory.CONNECTION_STRING);
        return optionsBuilder.Options;
    }

}

