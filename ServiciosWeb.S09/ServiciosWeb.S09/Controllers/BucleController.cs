using Microsoft.AspNetCore.Mvc;

namespace ServiciosWeb.S09.Controllers
{
    [ApiController]
    [Route("api/bucles")]
    public class BucleController : ControllerBase
    {
        // 1. Tabla de multiplicar 
        [HttpGet("tabla-multiplicar/{numero}")]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<string> tabla = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                tabla.Add($"{numero} x {i} = {numero * i}");
            }

            return Ok(string.Join("\n", tabla));
        }

        // 2. Sumar números 
        [HttpGet("sumar-numeros/{n}")]
        public IActionResult SumarNumeros(int n)
        {
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            return Ok($"Suma de 1 a {n} = {suma}");
        }

        // 3. Números pares
        [HttpGet("numeros-pares/{n}")]
        public IActionResult NumerosPares(int n)
        {
            List<int> pares = new List<int>();

            for (int i = 2; i <= n; i += 2)
            {
                pares.Add(i);
            }

            return Ok(string.Join(", ", pares));
        }

        // 4. Factorial
        [HttpGet("factorial/{n}")]
        public IActionResult Factorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return Ok($"{n}! = {factorial}");
        }

        // 5. Validar acceso
        [HttpGet("validar-acceso/{usuario}/{clave}")]
        public IActionResult ValidarAcceso(string usuario, string clave)
        {
            if (usuario == "admin" && clave == "123")
            {
                return Ok("Acceso concedido");
            }

            return Ok("Acceso denegado");
        }

        // 6. Lista de productos
        [HttpGet("lista-productos")]
        public IActionResult ListaProductos()
        {
            List<string> productos = new List<string>
            {
                "Laptop",
                "Mouse",
                "Teclado",
                "Monitor",
                "Impresora"
            };

            return Ok(string.Join(", ", productos));
        }

        // 7. Fibonacci
        [HttpGet("fibonacci/{n}")]
        public IActionResult Fibonacci(int n)
        {
            List<int> serie = new List<int>();

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                serie.Add(a);
                int temp = a + b;
                a = b;
                b = temp;
            }

            return Ok(string.Join(", ", serie));
        }
    }
}