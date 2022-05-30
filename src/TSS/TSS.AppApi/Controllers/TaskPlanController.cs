using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TSS.BllServices;
using TSS.Models;
using TSS.Models.DtoModelss;

namespace TSS.AppApi.Controllers
{
    /// <summary>
    /// task plan manage control
    /// </summary>
    [Route("api/[controller]")]
    public class TaskPlanController : Controller
    {
        /// <summary>
        /// task plan bll service
        /// </summary>
        private ITaskPlanBllService TaskPlanBllService { get; set; }

        /// <summary>
        /// instance method
        /// </summary>
        /// <param name="taskPlanBllService">register task plan bll service.</param>
        public TaskPlanController(ITaskPlanBllService taskPlanBllService)
        {
            this.TaskPlanBllService = taskPlanBllService;
        }

        /// <summary>
        /// register a task plan
        /// </summary>
        /// <param name="task">task plan model</param>
        /// <returns></returns>
        public ResponseResult<string> Register([FromBody]TaskDtoModel task)
        {

            return new ResponseResult<string>();
        }

        /// <summary>
        /// update current task plan
        /// </summary>
        /// <param name="task">task plan model</param>
        /// <returns></returns>
        public ResponseResult Update([FromQuery]string taskId, [FromBody]TaskDtoModel task)
        {
            return null;
        }

        /// <summary>
        /// remove target task plan
        /// </summary>
        /// <param name="taskId">target task plan id</param>
        /// <returns></returns>
        public ResponseResult Remove([FromQuery]string taskId)
        {
            return null;
        }

        /// <summary>
        /// start target task plan
        /// </summary>
        /// <param name="taskId">target task plan id</param>
        /// <returns></returns>
        public ResponseResult Start([FromQuery]string taskId)
        {
            return null;
        }

        /// <summary>
        /// pause target task plan
        /// </summary>
        /// <param name="taskId">target task plan id</param>
        /// <returns></returns>
        public ResponseResult Pause([FromQuery]string taskId)
        {
            return null;
        }

        /// <summary>
        /// get page collection data
        /// </summary>
        /// <param name="condition">query condition</param>
        /// <returns></returns>
        public PageResponseResult<TaskDtoModel> GetPage([FromQuery] PageQueryCondition condition)
        {
            return null;
        }
    }
}

