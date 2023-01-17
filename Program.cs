using Models;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<ISignetsService, SignetsService>();

var app = builder.Build();

((IApplicationBuilder)app).UseSoapEndpoint<ISignetsService>("/Secure/WebServices/SignetsMobile.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);

app.Run();
