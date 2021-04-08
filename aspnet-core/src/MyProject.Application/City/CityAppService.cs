using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyProject.City.Dto;
using MyProject.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.City
{
    public class CityAppService : MyProjectAppServiceBase, ICityAppService
    {
        //private readonly MyProjectDbContext _context;

        //public CityAppService(MyProjectDbContext context)
        //{
        //    _context = context;
        //}
        private readonly IRepository<CityEntity> _cityRepository;

        public CityAppService(IRepository<CityEntity> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task<List<CityDto>> GetAllCity()
        {

            //var query = from x in _context.Citys
            //            select x;

            //var data = await query.Select(x => new CityDto()
            //{
            //    Id = x.Id,
            //    Name = x.Name
            //}).ToListAsync();

            var tasks = await _cityRepository
                .GetAll()
                .ToListAsync();

            return new List<CityDto>(
                ObjectMapper.Map<List<CityDto>>(tasks)
            );
         
        }
    }
}
