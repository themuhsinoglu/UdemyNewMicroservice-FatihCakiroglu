using UdemyNewMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();
builder.Services.AddCommonServiceExt(typeof(FileAssembly));
builder.Services.AddVersioningExt();

var app = builder.Build();
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();
app.MapOpenApi();



app.Run();
