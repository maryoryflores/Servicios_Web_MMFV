using Microsoft.AspNetCore.Mvc;

namespace ServiciosWeb.S09.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CondicionalesController : ControllerBase
    {
        // 1. Clasificar Edad

        [HttpGet("clasificar-edad/{edad}")]
        public IActionResult ClasificarEdad(int edad)
        {
            string resultado;

            if (edad < 13)
            {
                resultado = "Eres un niño";
            }
            else if (edad < 18)
            {
                resultado = "Eres un adolescente";
            }
            else
            {
                resultado = "Eres un adulto";
            }

            return Ok(new { resultado });
        }

        // 2. Validar Acceso

        [HttpGet("validar-acceso/{usuario}/{clave}")]
        public IActionResult ValidarAcceso(string usuario, string clave)
        {
            string resultado;

            if (usuario == "admin" && clave == "123")
            {
                resultado = "Acceso concedido - Administrador";
            }
            else if (usuario == "user" && clave == "123")
            {
                resultado = "Acceso concedido - Usuario";
            }
            else
            {
                resultado = "Acceso denegado";
            }

            return Ok(new { resultado });
        }

        // 3. Calcular Descuento

        [HttpGet("calcular-descuento/{tipo}/{monto}")]
        public IActionResult CalcularDescuento(string tipo, double monto)
        {
            double descuento = 0;

            switch (tipo.ToLower())
            {
                case "vip":
                    descuento = 0.20;
                    break;

                case "regular":
                    descuento = 0.10;
                    break;

                case "nuevo":
                    descuento = 0.05;
                    break;
            }

            double total = monto - (monto * descuento);

            return Ok(new
            {
                resultado = $"Total a pagar: S/. {total:F2}"
            });
        }

        // 4. Día de la Semana

        [HttpGet("dia-semana/{numero}")]
        public IActionResult DiaSemana(int numero)
        {
            string resultado;

            switch (numero)
            {
                case 1:
                    resultado = "Lunes";
                    break;

                case 2:
                    resultado = "Martes";
                    break;

                case 3:
                    resultado = "Miércoles";
                    break;

                case 4:
                    resultado = "Jueves";
                    break;

                case 5:
                    resultado = "Viernes";
                    break;

                case 6:
                    resultado = "Sábado";
                    break;

                case 7:
                    resultado = "Domingo";
                    break;

                default:
                    resultado = "Número inválido";
                    break;
            }

            return Ok(new { resultado });
        }
    }
}