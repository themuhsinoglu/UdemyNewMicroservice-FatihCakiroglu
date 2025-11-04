using UdemyNewMicroservice.Basket.Api;
using UdemyNewMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddCommonServiceExt(typeof(BasketAssembly));
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});
builder.Services.AddVersioningExt();

var app = builder.Build();



app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();



app.Run();
