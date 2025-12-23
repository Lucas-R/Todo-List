using Microsoft.EntityFrameworkCore;
using System;
using TodoApp.Data;
using TodoApp.Services;
using TodoList.Data.Repositories;
using TodoList.Interfaces;
using TodoList.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(o =>
    o.UseSqlite("Data Source=todo.db"));

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<ITodoService, TodoService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();