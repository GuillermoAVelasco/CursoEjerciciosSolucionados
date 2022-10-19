using AspNetCore1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspNetCore1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebasController : ControllerBase
    {      
        
        private readonly ResourcesHub _resource;
        private IPersona _persona;
        private IVehiculo _vehiculo;
        private IRubro _rubro;
        //3)	Crea una clase y accede al valor de las configuraciones utilizando la Interfaz IOptions<T>
        public PruebasController(IOptions<ResourcesHub> ioptions,IPersona persona, IVehiculo vehiculo, IRubro rubro)
        {            
            _resource = ioptions.Value;
            Console.WriteLine("Ingresando a PruebasController");
            Console.WriteLine("Mostrando  algunos valores de appsettings:");
            Console.WriteLine("Host " + _resource.Host+ " Token "+_resource.Token);
            
            Console.WriteLine();
            Console.WriteLine(persona.ToString()+" HashCode: "+persona.GetHashCode());
            this._persona = persona;
            this._vehiculo = vehiculo;
            this._rubro = rubro;
        }
        

        [HttpGet]
        public object Get()
        {
            return "Ok";
        }

        [HttpGet("GetCountries")]
        public IActionResult GetCountries()
        {
            return Ok("Valor GetCountries:" +_resource.Endpoints.GetCountries);
        }

        //4)	Sobreescribe el valor de GetUsers para el ambiente de desarrollo
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok("Valor GetUsers:" + _resource.Endpoints.GetUsers);
        }

        [HttpGet("ObtenerPersonaHashCode")]
        public IActionResult PersonaHasHCode()
        {
            var cadena = "Persona: " + _persona.GetType() + " " + _persona.ToString() + " Hash Code:" + _persona.GetHashCode();
            Console.WriteLine(cadena);
            return Ok(cadena);
        }

        [HttpGet("ObtenerVehiculoHashCode")]
        public IActionResult VehiculoHasHCode()
        {
            var cadena = "Vehiculo: " + _vehiculo.GetType() + " Velocidad: " + _vehiculo.velocidad() + " Hash Code:" + _vehiculo.GetHashCode();
            Console.WriteLine(cadena);
            return Ok(cadena);
        }

        [HttpGet("ObtenerRubroHashCode")]
        public IActionResult RubroHasHCode()
        {
            var cadena = "Rubro: " + _rubro.GetType() + " Rubro: " + _rubro.mostrar() + " Hash Code:" + _rubro.GetHashCode();
            Console.WriteLine(cadena);
            return Ok(cadena);
        }

    }
}