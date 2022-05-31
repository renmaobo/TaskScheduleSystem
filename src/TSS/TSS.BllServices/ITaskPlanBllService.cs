// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	ITaskPlanBllService
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/30 下午10:13
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/30 下午10:13
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using TSS.Models;
using TSS.Models.DtoModelss;

namespace TSS.BllServices
{
	/// <summary>
    /// task plan interface bll-service
    /// </summary>
	public interface ITaskPlanBllService
	{
        public ResponseResult<string> Register(TaskDtoModel taskDtoModel);

        public ResponseResult Update(string taskId, TaskDtoModel taskDtoModel);

        public ResponseResult Remove(string taskId);

        public ResponseResult Start(string taskId);

        public ResponseResult Pause(string taskId);

        public PageResponseResult<TaskDtoModel> GetPage(PageQueryCondition condition);
    }
}

