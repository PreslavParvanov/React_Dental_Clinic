using DentalClinic.BL.Contracts;
using DentalClinic.BL.Service;
using DentalClinic.DB.Data;
using DentalClinic.DB.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Mvc;
using DentalClinic.ModelBinders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedAccount");
    options.SignIn.RequireConfirmedEmail = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedEmail");
    options.SignIn.RequireConfirmedPhoneNumber = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedPhoneNumber");
    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:RequiredLength");
    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:RequireNonAlphanumeric");
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
        options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Users/Login";
});

builder.Services.AddScoped<IDoctorService, DentalClinic.BL.Service.DoctorService>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IErrorService, ErrorService>();
builder.Services.AddScoped<IDentalService, DentalSrvService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IReceptionService, ReceptionService>();
builder.Services.AddScoped<ICloudinaryService, CloudinaryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    

    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapRazorPages();
});

app.UseResponseCaching();

app.Run();
