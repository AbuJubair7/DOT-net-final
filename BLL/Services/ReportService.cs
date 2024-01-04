using System;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
    public class ReportService
    {
        public static List<ReportDTO> Get()
        {
            return Conversion<Report, ReportDTO>.ConvertToList(DataAccessFactory.ReportData().Get());
        }

        public static ReportDTO Get(int id)
        {
            return Conversion<Report, ReportDTO>.Convert(DataAccessFactory.ReportData().Get(id));
        }

        public static ReportDTO Create(ReportDTO data)
        {
            var mapped = Conversion<ReportDTO, Report>.Convert(data);
            var ret = DataAccessFactory.ReportData().Create(mapped);

            return Conversion<Report, ReportDTO>.Convert(ret);
        }

        public static ReportDTO Update(ReportDTO data)
        {
            var mapped = Conversion<ReportDTO, Report>.Convert(data);
            var ret = DataAccessFactory.ReportData().Update(mapped);

            return Conversion<Report, ReportDTO>.Convert(ret);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ReportData().Delete(id);
        }
    }

}

