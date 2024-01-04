using System;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
    public class CompanyService
    {
        public static List<CompanyDTO> Get()
        {
            return Conversion<Company, CompanyDTO>.ConvertToList(DataAccessFactory.CompanyData().Get());
        }

        public static CompanyDTO Get(int id)
        {
            return Conversion<Company, CompanyDTO>.Convert(DataAccessFactory.CompanyData().Get(id));
        }

        public static CompanyDTO Create(CompanyDTO data)
        {
            var mapped = Conversion<CompanyDTO, Company>.Convert(data);
            var ret = DataAccessFactory.CompanyData().Create(mapped);

            return Conversion<Company, CompanyDTO>.Convert(ret);
        }

        public static CompanyDTO Update(CompanyDTO data)
        {
            var mapped = Conversion<CompanyDTO, Company>.Convert(data);
            var ret = DataAccessFactory.CompanyData().Update(mapped);

            return Conversion<Company, CompanyDTO>.Convert(ret);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CompanyData().Delete(id);
        }
    }

}

