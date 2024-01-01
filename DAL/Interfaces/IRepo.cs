using System;
namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID, RET>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RET Create(CLASS obj);
        RET Update(CLASS obj);
        bool Delete(ID id);
    }
}

