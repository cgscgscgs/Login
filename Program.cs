/*
 * date             dev                 changes 
 * 1/21/2025        celina schlecht     creation of this program file
 * 1/22/2025        celina schlecht     added using statements for Identity, edited AddDefaultIdentity to access ApplicationUser class,  
 * 
 * 
 * 
 * 
 */





using Login.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Login.Areas.Identity; //this allows us to use ApplicationUser class

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Database draws info from ApplicationUser class which extends IdentityUser
// Orignally said IdentityUser here
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
   // .AddDefaultTokenProviders(); // fixes issue no service for type has been registered

builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor(); // Support for Blazor, fixes issue with missing service for type



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
