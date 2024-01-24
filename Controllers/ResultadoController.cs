using API_PRUEBA_PROGRESO3.Data;
using API_PRUEBA_PROGRESO3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API_PRUEBA_PROGRESO3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public ResultadoController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Resultado
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Resultado> resultados = await _dbContext.Resultados.ToListAsync();

            return resultados == null ? BadRequest("Hubo un error al consultar los resultados") : Ok(resultados);
        }

        // GET: api/Resultado/5
        [HttpGet("{idResultado}")]
        public async Task<IActionResult> Get(int idResultado)
        {
            Resultado resultadoFound = await _dbContext.Resultados.FirstOrDefaultAsync(data => data.idUsuario == idResultado);
            return resultadoFound == null ? BadRequest() : Ok(resultadoFound);
        }

        // POST: api/Resultado
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Resultado newResultado)
        {
            Resultado resultadoFound = await _dbContext.Resultados.FirstOrDefaultAsync(data => data.idUsuario == newResultado.idUsuario);

            if (newResultado == null || resultadoFound != null)
            {
                return BadRequest("El nuevo resultado tiene errores o ya existe el resultado a registrar");
            }

            await _dbContext.Resultados.AddAsync(newResultado);
            await _dbContext.SaveChangesAsync();

            return Ok(newResultado);
        }

        // PUT: api/Resultado/5
        [HttpPut("{idResultado}")]
        public async Task<IActionResult> Put(int idResultado, [FromBody] Resultado newResultado)
        {
            Resultado resultadoToReplace = await _dbContext.Resultados.FirstOrDefaultAsync(data => data.idUsuario == idResultado);

            if (newResultado == null || resultadoToReplace == null)
            {
                return BadRequest("El nuevo resultado tiene errores o no existe el resultado a reemplazar");
            }

            resultadoToReplace.nombre = newResultado.nombre ?? resultadoToReplace.nombre;
            resultadoToReplace.resultado = newResultado.resultado;
            resultadoToReplace.CantidadVictorias = newResultado.CantidadVictorias;
            resultadoToReplace.fechaResultado = newResultado.fechaResultado;

            await _dbContext.SaveChangesAsync();

            return Ok(resultadoToReplace);
        }

        // DELETE: api/Resultado/5
        [HttpDelete("{idUsuario}")]
        public async Task<IActionResult> Delete(int idUsuario)
        {
            Resultado resultadoToDelete = await _dbContext.Resultados.FirstOrDefaultAsync(data => data.idUsuario == idUsuario);

            if (resultadoToDelete == null)
            {
                return BadRequest("No se ha encontrado el resultado a borrar");
            }

            _dbContext.Remove(resultadoToDelete);
            await _dbContext.SaveChangesAsync();

            return Ok("El resultado ha sido eliminado correctamente");
        }
    }
}
