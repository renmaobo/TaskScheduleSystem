// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	MongoContext
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/5/30 下午10:39
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/5/30 下午10:39
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using MongoDB;

namespace TSS.Models.DbModels
{
    /// <summary>
    /// mongo database context
    /// </summary>
    public class MongoDbContext : DbContext
    {
        public MongoDbContext(string connectionString) : base(connectionString: connectionString) { }

        public DbCollection<TaskPlanDbModel> TaskPlanCollection { get; set; }
    }
}

