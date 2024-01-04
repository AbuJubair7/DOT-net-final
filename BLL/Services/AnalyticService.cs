using System;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
	public class AnalyticService
	{
        public static List<AnalyticDTO> Get()
        {
            return Conversion<Analytic, AnalyticDTO>.ConvertToList(DataAccessFactory.AnalyticData().Get());
        }
        public static AnalyticDTO Get(int id)
        {

            return Conversion<Analytic, AnalyticDTO>.Convert(DataAccessFactory.AnalyticData().Get(id));
        }
        public static AnalyticDTO Create(AnalyticDTO data)
        {
            var mapped = Conversion<AnalyticDTO, Analytic>.Convert(data);
            var ret = DataAccessFactory.AnalyticData().Create(mapped);

            return Conversion<Analytic, AnalyticDTO>.Convert(ret);
        }
        public static AnalyticDTO Update(AnalyticDTO data)
        {
            var mapped = Conversion<AnalyticDTO, Analytic>.Convert(data);
            var ret = DataAccessFactory.AnalyticData().Update(mapped);

            return Conversion<Analytic, AnalyticDTO>.Convert(ret);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AnalyticData().Delete(id);
        }
    }
}

