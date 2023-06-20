using API_backend_childsplay.Info;
using Dapper;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
const string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cp.database;Integrated Security=True;";

if (builder.Environment.IsDevelopment())
{
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
}

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowAllOrigins");
}


app.UseHttpsRedirection();


//TODO LIST 

//get tasks
app.MapGet("/to-do-list", async () =>
{
    var conn = new SqlConnection(connStr);
    const string sql = "SELECT Id, Task, IsCompleted, Date, Done FROM Task ORDER BY Date";
    var tasks = await conn.QueryAsync<ToDoTask>(sql);
    return tasks;
});

//create new task
app.MapPost("/to-do-list", async (string task) =>
{
    var conn = new SqlConnection(connStr);
    var newTask = new ToDoTask(task);

    const string sql = "INSERT INTO Task (id, task, isCompleted, date, done) VALUES (@Id, @Task, @IsCompleted, @Date, @Done)";
    return await conn.ExecuteAsync(sql, new { newTask.Id, newTask.Task, newTask.IsCompleted, newTask.Date, newTask.Done });
});

//checkbox
app.MapPut("/to-do-list", async (ToDoTask task) =>
{
    task.ToggleComplete();
    var conn = new SqlConnection(connStr);
    string sql = "UPDATE Task SET IsCompleted = CASE WHEN @IsCompleted = 1 THEN 1 ELSE 0 END";
    if (task.IsCompleted)
    {
        sql += ", Done = GETDATE()";
    }
    else
    {
        sql += ", Done = NULL";
    }
    sql += " WHERE Id = @Id;";
    return await conn.ExecuteAsync(sql, task);

});

//delete IN SETTINGS
app.MapDelete("/settings", async () =>
{
    var conn = new SqlConnection(connStr);
    const string sql = "DELETE FROM Task";
    return await conn.ExecuteAsync(sql);

});

app.Run();

