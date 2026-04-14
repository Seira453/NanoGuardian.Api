using Microsoft.AspNetCore.Mvc;
using NanoGuardian.Api.Models;

namespace NanoGuardian.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        [HttpPost]
        public IActionResult RecibirAlerta([FromBody] AlertaZapato alerta)
        {
            if (string.IsNullOrEmpty(alerta.Usuario))
            {
                return BadRequest("El nombre del usuario es obligatorio.");
            }

            // Simulación del backend
            Console.WriteLine($"🚨 ALERTA ZAPATO BIÓNICO:");
            Console.WriteLine($"Usuario: {alerta.Usuario}");
            Console.WriteLine($"Impacto: {alerta.Impacto}");
            Console.WriteLine($"Estado: {alerta.Estado}");

            return Ok(new
            {
                mensaje = "Alerta del zapato procesada correctamente",
                codigo = 200
            });
        }
    }
}