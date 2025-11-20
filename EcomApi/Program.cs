using Microsoft.EntityFrameworkCore;
using EcomApi.DataAccess.Context;
using EcomApi.Mapping;
using EcomApi.Interfaces.IRepository;
using EcomApi.DataAccess.Repository;
using EcomApi.Managers;
using EcomApi.Services;
using EcomApi.Interfaces.IManagers;
using EcomApi.Interfaces.IServices;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")!, b =>
             b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers();
builder.Services.AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IOrderManager), typeof(OrderManager));
builder.Services.AddScoped(typeof(IProductManager), typeof(ProductManager));
builder.Services.AddScoped(typeof(IUserManager), typeof(UserManager));
builder.Services.AddScoped(typeof(IOrderService), typeof(OrderService));
builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));
builder.Services.AddScoped(typeof(IUserService), typeof(UserService));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
