// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	ITaskPlanDalService
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/30 下午10:18
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/30 下午10:18
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using TSS.Models;
using TSS.Models.DbModels;

namespace TSS.DalServices
{
    /// <summary>
    /// task plan interface dal-service
    /// </summary>
    public interface ITaskPlanDalService
    {
        public ResponseResult<string> Register(TaskPlanDbModel taskPlanDbModel);

        public ResponseResult Update(string taskId, TaskPlanDbModel taskPlanDbModel);

        public ResponseResult Remove(string taskId);

        public ResponseResult Start(string taskId);

        public ResponseResult Pause(string taskId);

        public PageResponseResult<TaskPlanDbModel> GetPage(PageQueryCondition condition);
    }
}

