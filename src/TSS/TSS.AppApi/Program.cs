﻿using TSS.BllServices;
using TSS.BllServices.ImplServices;
using TSS.DalServices;
using TSS.DalServices.ImplServices;
using TSS.Models.DbModels;
using MongoDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region service register
// Because operation logic services are simple and few to build, a three-tier architecture is used to build business operations.
builder.Services.AddScoped<ITaskPlanDalService, TaskPlanDalService>();
builder.Services.AddScoped<ITaskPlanBllService, TaskPlanBllService>();

// register mongodb context
builder.Services.AddMongoContext(options => options.UseMongoContext<MongoDbContext>(builder.Configuration.GetConnectionString("")));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

