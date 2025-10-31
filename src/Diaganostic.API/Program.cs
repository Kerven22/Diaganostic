using System.Reflection;
using Diaganostic.API.Extentions;
using Diaganostic.API.Mapping;
using Diaganostic.Storage.DbContexts;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(ApiProfile)));
builder.Services.AddMediatR(cft => cft.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddSqlServer<DiaganosticDbContext>(builder.Configuration.GetConnectionString("sqlServer"),
    b => b.MigrationsAssembly("Diaganostic.API"));
builder.Services.AddSerilogExtention(builder.Environment, builder.Configuration); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Diaganostic");
    });
}

app.MapControllers(); 
app.UseHttpsRedirection();
app.Run();