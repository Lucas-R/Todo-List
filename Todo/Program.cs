using Microsoft.EntityFrameworkCore;
using TodoList.Services;
using TodoList.Data.Repositories;
using TodoList.Interfaces;
using TodoList.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Database>(o =>
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