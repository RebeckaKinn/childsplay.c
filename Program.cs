using Microsoft.OpenApi.Models;
using SideProjectApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

var db = new DB();

app.MapGet("/swagger", () => db);

app.MapPost("/fooditems", (string name, string description, int difficulty) =>
{
    db.NewFoodItem(name, description, difficulty);
    return db;
});

app.MapGet("/showFood", () => db.ShowFood());

app.MapPost("/activities", (string name, string description) =>
{
    db.NewActivity(name, description);
    return db;
});

app.MapGet("/showActivities", () => db.ShowActivity());

app.MapPost("/todoList", (string task) =>
{
    db.NewToDo(task);
    return db;
});

app.MapGet("/showToDoList", () => db.ShowToDo());

app.Run();