// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	BaseDtoModel
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/26 下午10:34
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/26 下午10:34
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace TSS.Models
{
	/// <summary>
    /// base dto model
    /// </summary>
	public class BaseDtoModel
	{
		/// <summary>
        /// valid data format verify
        /// </summary>
        /// <returns></returns>
		public virtual bool IsValidFormat() => true;
	}
}

