// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	ResponseResult
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/26 下午10:23
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/26 下午10:23
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace TSS.Models
{
    /// <summary>
    /// response result
    /// </summary>
    public class ResponseResult
    {
        /// <summary>
        /// instance method
        /// </summary>
        /// <param name="status">info status</param>
        /// <param name="errmsg">error message</param>
        public ResponseResult(bool status = true, string errmsg = "success")
        {
            this.Status = status;
            this.ErrMsg = errmsg;
        }

        /// <summary>
        /// status property
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// error message property
        /// </summary>
        public string ErrMsg { get; set; }
    }

    /// <summary>
    /// response result
    /// </summary>
    /// <typeparam name="Tdata"><user-defined data types/typeparam>
    public class ResponseResult<Tdata> : ResponseResult
    {
        /// <summary>
        /// instance method
        /// </summary>
        /// <param name="status">info status</param>
        /// <param name="errmsg">error message</param>
        /// <param name="data">user-defined data</param>
        public ResponseResult(bool status = true, string errmsg = "success", Tdata data = default) : base(status, errmsg)
        {
            this.Data = data;
        }

        /// <summary>
        /// user-defined data
        /// </summary>
        public Tdata Data { get; set; }
    }
}

