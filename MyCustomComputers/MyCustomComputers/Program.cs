﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCustomComputers.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyCustomComputersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCustomComputersContext") ?? throw new InvalidOperationException("Connection string 'MyCustomComputersContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p=>p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
