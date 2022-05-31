// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	TaskPlanBllService
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/30 下午10:19
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/30 下午10:19
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using TSS.DalServices;
using TSS.Models;
using TSS.Models.DtoModelss;

namespace TSS.BllServices.ImplServices
{
    /// <summary>
    /// task plan bll-service
    /// </summary>
    public class TaskPlanBllService : ITaskPlanBllService
    {
        /// <summary>
        /// task plan dal servce
        /// </summary>
        private ITaskPlanDalService TaskPlanDalService { get; set; }

        /// <summary>
        /// instance method
        /// </summary>
        /// <param name="taskPlanDalService">register task plan dal service</param>
        public TaskPlanBllService(ITaskPlanDalService taskPlanDalService)
        {
            this.TaskPlanDalService = taskPlanDalService;
        }

        public ResponseResult<string> Register(TaskDtoModel taskDtoModel)
        {
            var taskPlan = taskDtoModel.Convert();
            return this.TaskPlanDalService.Register(taskPlanDbModel: taskPlan);
        }

        public ResponseResult Update(string taskId, TaskDtoModel taskDtoModel)
        {
            var taskPlan = taskDtoModel.Convert();
            return this.TaskPlanDalService.Update(taskId: taskId, taskPlanDbModel: taskPlan);
        }

        public ResponseResult Remove(string taskId)
        {
            return this.TaskPlanDalService.Remove(taskId: taskId);
        }

        public ResponseResult Start(string taskId)
        {
            return this.TaskPlanDalService.Start(taskId: taskId);
        }

        public ResponseResult Pause(string taskId)
        {
            return this.TaskPlanDalService.Pause(taskId: taskId);
        }

        public PageResponseResult<TaskDtoModel> GetPage(PageQueryCondition condition)
        {
            var result = this.TaskPlanDalService.GetPage(condition: condition);

            return new PageResponseResult<TaskDtoModel>(status: result.Status, errmsg: result.ErrMsg)
            {
                Data = result.Data.Convert()
        };
    }
}
}

