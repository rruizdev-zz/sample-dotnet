using MediatR;
using SampleDotnet.Application.Extensions;
using SampleDotnet.Infrastructure.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("meliService", c => c.BaseAddress = new Uri("https://api.mercadolibre.com"));

builder.Services.AddRepositories();

builder.Services.AddMappers();

builder.Services.AddControllers();  

builder.Services.AddMediatR(Assembly.Load("SampleDotnet.Application"));

builder.Services.AddSwaggerGen(o => o
    .IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml")));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(o =>
    {
        o.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        o.RoutePrefix = string.Empty;
    });
}

app.Run();
