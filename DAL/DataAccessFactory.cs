
using DAL.Model.Entity;
using DAL.Interfaces;
using DAL.Repo;

namespace DAL;

public class DataAccessFactory
{
    public static IRepo<Campaign, string, Campaign>  CampaignData ()
    {
        return new CampaignRepo();
    }
    public static IRepo<Conversion, string, Conversion> ConversionData()
    {
        return new ConversionRepo();
    }

}

