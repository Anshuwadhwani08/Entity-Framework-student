using Microsoft.EntityFrameworkCore;
using Student_Project.Repository;
using Student_Project.StudentDbcontext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<studentDbcontext> ( Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbConnection"));
});

builder.Services.AddScoped<IstudentRepository, studentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
