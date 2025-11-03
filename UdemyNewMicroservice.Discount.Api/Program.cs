using UdemyNewMicroservice.Discount.Api;
using UdemyNewMicroservice.Discount.Api.Features.Discounts;
using UdemyNewMicroservice.Discount.Api.Options;
using UdemyNewMicroservice.Discount.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptionsExt();
builder.Services.AddDatabaseServiceExt();
builder.Services.AddCommonServiceExt(typeof(DiscountAssembly));
builder.Services.AddVersioningExt();

var app = builder.Build();

app.AddDiscountGroupEndpointExt(app.AddVersionSetExt());


app.UseSwagger();
app.UseSwaggerUI();



app.Run();

