using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.OOPConsole.Utility;
using YetgenAkbankJump.WebApi.Services;
using YetgenAkbankJump.Shared.Utility;
using YetgenAkbankJump.Shared.Services;
using YetgenAkbankJump.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordGenerator>();
builder.Services.AddSingleton<RequestCountService>(new RequestCountService());

var textPath = builder.Configuration.GetSection("TextPath").Value;

builder.Services.AddSingleton<IIPService, IPService>();

builder.Services.AddSingleton<ITextService, TextService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

builder.Services.AddSharedServices();


builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var trCulture = new CultureInfo("tr-TR");

    List<CultureInfo> cultureInfos = new()
    {
        trCulture,
        new("en-GB"),
    };

    options.SupportedCultures = cultureInfos;
    options.SupportedUICultures = cultureInfos;
    options.DefaultRequestCulture = new RequestCulture(trCulture);
    options.ApplyCurrentCultureToResponseHeaders = true;
});

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

var app = builder.Build();

app.UseCors("AllowAll");

var requestLocalizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();

if(requestLocalizationOptions is not null) app.UseRequestLocalization(requestLocalizationOptions.Value);

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
