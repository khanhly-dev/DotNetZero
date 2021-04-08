using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.City.Dto
{
    [AutoMap(typeof(CityEntity))]
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
