using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TSS.Models;
using TSS.Models.DtoModelss;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TSS.AppApi.Controllers
{
    [Route("api/[controller]")]
    public class TaskPlanController : Controller
    {
        public ResponseResult<string> Add(TaskDtoModel task)
        {
            return new ResponseResult<string>();
        }
    }
}

