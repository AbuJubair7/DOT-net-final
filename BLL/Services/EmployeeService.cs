using System;
using BLL.DTOs;
using DAL;
using DAL.Model.Entity;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static List<EmployeeDTO> Get()
        {
            return Conversion<Employee, EmployeeDTO>.ConvertToList(DataAccessFactory.EmployeeData().Get());
        }

        public static EmployeeDTO Get(int id)
        {
            return Conversion<Employee, EmployeeDTO>.Convert(DataAccessFactory.EmployeeData().Get(id));
        }

        public static EmployeeDTO Create(EmployeeDTO data)
        {
            var mapped = Conversion<EmployeeDTO, Employee>.Convert(data);
            var ret = DataAccessFactory.EmployeeData().Create(mapped);

            return Conversion<Employee, EmployeeDTO>.Convert(ret);
        }

        public static EmployeeDTO Update(EmployeeDTO data)
        {
            var mapped = Conversion<EmployeeDTO, Employee>.Convert(data);
            var ret = DataAccessFactory.EmployeeData().Update(mapped);

            return Conversion<Employee, EmployeeDTO>.Convert(ret);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployeeData().Delete(id);
        }
    }

}

