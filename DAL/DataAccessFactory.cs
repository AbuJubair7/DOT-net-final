
using DAL.Model.Entity;
using DAL.Interfaces;
using DAL.Repo;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DataAccessFactory
{
    internal static string CONNECTION_STRING = "Host=localhost;Port=5432;Database=ASP;Username=postgres;Password=7777;";
    public static IRepo<Campaign, int, Campaign> CampaignData()
    {

        return new CampaignRepo(DataAccessFactory.CreateOptions());
    }

    public static IRepo<Analytic, int, Analytic> AnalyticData()
    {

        return new AnalyticRepo(DataAccessFactory.CreateOptions());
    }

    public static IRepo<Company, int, Company> CompanyData()
    {
        return new CompanyRepo(DataAccessFactory.CreateOptions());
    }

    public static IRepo<Employee, int, Employee> EmployeeData()
    {
        return new EmployeeRepo(DataAccessFactory.CreateOptions());
    }

    public static IRepo<Report, int, Report> ReportData()
    {
        return new ReportRepo(DataAccessFactory.CreateOptions());
    }

    private static DbContextOptions<AppDbContext> CreateOptions()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(DataAccessFactory.CONNECTION_STRING);
        return optionsBuilder.Options;
    }

}

