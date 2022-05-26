// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	TaskDtoModel
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/26 下午10:35
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/26 下午10:35
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace TSS.Models.DtoModelss
{
    /// <summary>
    /// task transfer model
    /// </summary>
    public class TaskDtoModel : BaseDtoModel
    {
        /// <summary>
        /// task name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// task plan excute time core expression
        /// </summary>
        public string PlanTimeCorn { get; set; }

        /// <summary>
        /// task visit url address
        /// </summary>
        public string VisitAddress { get; set; }

        /// <summary>
        /// immediate execution
        /// </summary>
        public bool IsRunNow { get; set; }

        /// <summary>
        /// valid data format verify
        /// </summary>
        /// <returns></returns>
        public override bool IsValidFormat()
        {
            return base.IsValidFormat();
        }
    }
}

