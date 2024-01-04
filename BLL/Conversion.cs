using System;
using AutoMapper;

namespace BLL.DTOs
{
	public class Conversion<OBJ1, OBJ2>
	{
        public static OBJ2 Convert(OBJ1 data)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OBJ1, OBJ2>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OBJ2>(data);
            return mapped;
        }
        public static List<OBJ2> ConvertToList(List<OBJ1> data)
		{
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OBJ1, OBJ2>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OBJ2>>(data);
            return mapped;
        }
	}
}

