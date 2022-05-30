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

namespace TSS.BllServices.ImplServices
{
	/// <summary>
    /// task plan bll-service
    /// </summary>
	public class TaskPlanBllService: ITaskPlanBllService
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
	}
}

