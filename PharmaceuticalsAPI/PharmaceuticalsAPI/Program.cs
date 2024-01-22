using PharmaceuticalsAPI;
using PharmaceuticalsAPI.DBService;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/getProducts/{includes}", (string includes) =>
{
    DBService dbService = new();
    return dbService.GetPharmaceuticals(includes) as IEnumerable<string>;
});

app.MapGet("/getPharmacies/{pharmaceutical}", (string pharmaceutical) =>
{
    DBService dbService = new();
    return dbService.GetPharmacies(pharmaceutical);
});

app.Run();