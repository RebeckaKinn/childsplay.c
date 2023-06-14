using Microsoft.OpenApi.Models;
using System.Data.SqlClient;
using SideProjectApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
const string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cp.database;Integrated Security=True;";

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


app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");


//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//});



//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//    });
//}


var db = new DB();

app.MapGet("/", async ()) => {
    var conn = new SqlConnection(connStr);
    const string sql = "";
    var getDB = await conn.QueryAsync<>(sql);
    return getDB;
};

app.MapPost("/fooditems", (string name, string description, int difficulty = 1) =>
{
    var conn = new SqlConnection(connStr);
    const string sql = "";
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