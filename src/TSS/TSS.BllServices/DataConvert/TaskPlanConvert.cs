// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	TaskPlanConvert
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/31 下午10:30
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/31 下午10:30
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using TSS.Models.DbModels;
using TSS.Models.DtoModelss;
using System.Collections.Generic;
using System.Linq;

namespace TSS.BllServices
{
    public static class TaskPlanConvert
    {
        public static TaskPlanDbModel Convert(this TaskDtoModel taskDtoModel)
            => new TaskPlanDbModel()
            {

            };

        public static TaskDtoModel Convert(this TaskPlanDbModel taskPlanDbModel)
            => new TaskDtoModel()
            {

            };

        public static IEnumerable<TaskPlanDbModel> Convert(this IEnumerable<TaskDtoModel> taskDtoModels) => taskDtoModels.Select(model => model.Convert());

        public static IEnumerable<TaskDtoModel> Convert(this IEnumerable<TaskPlanDbModel> taskPlanDbModels) => taskPlanDbModels.Select(model => model.Convert());
    }
}

