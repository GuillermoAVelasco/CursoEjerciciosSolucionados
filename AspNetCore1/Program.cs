using AspNetCore1.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


//2)	Accede al valor de GetCountries utilizando la interfaz IConfiguration.
var getCountries = builder.Configuration["ResourcesHub:Endpoints:getCountries"];
Console.WriteLine("Valor appsettings de getCountries:"+getCountries);
Console.WriteLine();

//3 Crea una clase y accede al valor de las configuraciones utilizando la Interfaz IOptions<T>
builder.Services.Configure<ResourcesHub>(builder.Configuration.GetSection("ResourcesHub"));

//5)	Sobreescribe el valor de Host utilizando una variable de entorno.
builder.Configuration["ResourcesHub:Host"]= Environment.GetEnvironmentVariable("OS");
Console.WriteLine("valor sobreescrito de Host con variable de entorno:"+builder.Configuration["ResourcesHub:Host"]);

// Add services to the container.
builder.Services.AddControllers();

//6)	Crea una clase y una interfaz, regístrala en el método ConfigureServices utilizando el ciclo de vida singleton e inyectala en un controlador.
//builder.Services.AddSingleton<IPersona, Profesor>();
builder.Services.AddSingleton<IPersona>(new Profesor("Pedro","Paramo","Literatura"));

//7)	Crea una clase y una interfaz, regístrala en el método ConfigureServices utilizando el ciclo de vida scope e inyectala en un controlador.
builder.Services.AddScoped<IVehiculo, Automovil>();

//8)	Crea una clase y una interfaz, regístrala en el método ConfigureServices utilizando el ciclo de vida trasient e inyectala en un controlador
builder.Services.AddTransient<IRubro,Farmacia>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
