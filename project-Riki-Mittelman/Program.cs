using project_Riki_Mittelman.Entities;
using Solid.Core.Service;
using Solid.Data;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
builder.Services.AddScoped<AvaibleProducts,AvaibleProducts>();
builder.Services.AddScoped<IAvailableProductsService,AvailableProductsService>();
builder.Services.AddScoped<AviableProduct,AviableProduct>();
builder.Services.AddScoped<IRecepiesService, RecepiesService>();
builder.Services.AddScoped<ShopingList, ShopingList>();
builder.Services.AddScoped<IShopingListService, ShopingListService>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();




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
