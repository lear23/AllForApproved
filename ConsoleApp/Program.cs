


using AllForApproved.Contexts;
using AllForApproved.Repositories;
using AllForApproved.Services;
using ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;



var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkolaUppgifter\AllForApproved\AllForApproved\Data\DataBaseCF.mdf;Integrated Security=True;Connect Timeout=30"));
   
    services.AddScoped<AddressRepo>();
    services.AddScoped<ContactRepo>();
    services.AddScoped<CustomerRepo>();
    services.AddScoped<CountryRepo>();
    services.AddScoped<UserRepo>();


    services.AddScoped<AddressService>();
    services.AddScoped<ContactService>();
    services.AddScoped<CustomerService>();
    services.AddScoped<CountryService>();
    services.AddScoped<UserService>();

    
 

    services.AddSingleton<MenuService>();
  


}).Build();

var menuService = builder.Services.GetRequiredService<MenuService>();
menuService.CreateCustomer_UI();


