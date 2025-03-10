using BilgisayarMagazasiSistemi.Business.Services;
using BilgisayarMagazasiSistemi.Core.Repositories;
using BilgisayarMagazasiSistemi.Data.Access;
using BilgisayarMagazasiSistemi.Data.Access.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connection String
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BilgisayarContext>(options => options.UseSqlServer(connectionString));

// Repository Bağımlılıkları
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// Service Bağımlılıkları
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOrderService, OrderService>();

// Controller desteği
builder.Services.AddControllersWithViews();

var app = builder.Build(); 


app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}"
);
app.MapControllers();
app.Run();

