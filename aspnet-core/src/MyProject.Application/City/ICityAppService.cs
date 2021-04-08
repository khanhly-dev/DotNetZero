using Abp.Application.Services.Dto;
using MyProject.City.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.City
{
    public interface ICityAppService 
    {
        Task<List<CityDto>> GetAllCity();
    }

}
