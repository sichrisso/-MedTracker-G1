
global using Microsoft.EntityFrameworkCore;
global using MedAdvisor.DataAccess.MySql;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MedAdvisor.Services.Okta.MedicineService;
using MedAdvisor.Services.Okta.AllergyService;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{

    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
/**
builder.Services.AddCors(p => p.AddPolicy("corsPolicy", build =>
{
    build.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
}));
*/
// Add services to the container.
builder.Services.AddDbContext<MedAdvisorDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MedAdvisor")));

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAllergyService, AllergyService>();
builder.Services.AddScoped<IMedicineService, MedicineService>();


var app = builder.Build();

app.UseCors("corsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();