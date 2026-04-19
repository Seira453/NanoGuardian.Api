using Microsoft.AspNetCore.Mvc;
using NanoGuardian.Api.Models;

namespace NanoGuardian.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        private static List<AlertaZapato> _alertas = new List<AlertaZapato>
        {
            new AlertaZapato { Usuario = "Usuario 1", Impacto = 0, Estado = "Sin caída" }
        };

        // ✅ GET para la app móvil
        [HttpGet]
        public IActionResult ObtenerAlertas()
        {
            return Ok(_alertas);
        }

        // ✅ POST para el ESP32/Wokwi
        [HttpPost]
        public IActionResult RecibirAlerta([FromBody] AlertaZapato alerta)
        {
            if (string.IsNullOrEmpty(alerta.Usuario))
                return BadRequest("El nombre del usuario es obligatorio.");

            _alertas.Add(alerta);
            Console.WriteLine($"🚨 ALERTA ZAPATO: {alerta.Usuario} - Impacto: {alerta.Impacto} - {alerta.Estado}");

            return Ok(new { mensaje = "Alerta del zapato procesada correctamente", codigo = 200 });
        }
    }
}