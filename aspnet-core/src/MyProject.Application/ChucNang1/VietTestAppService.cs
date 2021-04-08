using MyProject.ChucNang1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class VietTestAppService : MyProjectAppServiceBase
    {
        public MyOutputDto MyFunction(MyInputDto input)
        {
            return new MyOutputDto();
        }
    }
}
