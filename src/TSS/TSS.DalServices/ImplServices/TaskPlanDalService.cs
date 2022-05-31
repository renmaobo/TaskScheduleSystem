// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	TaskPlanDalService
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
using TSS.Models;
using TSS.Models.DbModels;

namespace TSS.DalServices.ImplServices
{
    /// <summary>
    /// task plan dal-service
    /// </summary>
    public class TaskPlanDalService : ITaskPlanDalService
    {
        private MongoDbContext DbContext { get; set; }

        public TaskPlanDalService(MongoDbContext mongoDbContext)
        {
            this.DbContext = mongoDbContext;
        }

        public ResponseResult<string> Register(TaskPlanDbModel taskPlanDbModel)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Update(string taskId, TaskPlanDbModel taskPlanDbModel)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Remove(string taskId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Start(string taskId)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Pause(string taskId)
        {
            throw new NotImplementedException();
        }

        public PageResponseResult<TaskPlanDbModel> GetPage(PageQueryCondition condition)
        {
            throw new NotImplementedException();
        }
    }
}

