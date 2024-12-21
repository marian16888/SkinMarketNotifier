using Microsoft.EntityFrameworkCore;
using SkinMarketNotifier.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure DbContext to use SQLite
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlite("Data Source=SkinMarketNotifier.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Add this line to serve static files
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();