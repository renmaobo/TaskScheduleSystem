// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	QueryCondition
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/30 下午9:24
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/30 下午9:24
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace TSS.Models
{
	/// <summary>
    ///  page query condition
    /// </summary>
	public class PageQueryCondition
	{
		/// <summary>
        /// offset value
        /// </summary>
		public int Offset { get; set; }

		/// <summary>
        /// limit value
        /// </summary>
		public int Limit { get; set; }
	}
}

