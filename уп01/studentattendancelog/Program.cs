using Microsoft.EntityFrameworkCore;
using studentattendancelog.data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Attendance_log>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentattendancelogDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
