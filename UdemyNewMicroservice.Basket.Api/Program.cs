using UdemyNewMicroservice.Basket.Api;
using UdemyNewMicroservice.Basket.Api.Features.Baskets;
using UdemyNewMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCommonServiceExt(typeof(BasketAssembly));
builder.Services.AddScoped<BasketService>();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});
builder.Services.AddVersioningExt();

var app = builder.Build();

app.AddBasketGroupEndpointExt(app.AddVersionSetExt());



app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();



app.Run();
