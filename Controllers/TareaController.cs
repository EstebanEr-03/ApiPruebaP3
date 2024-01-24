using API_PRUEBA_PROGRESO3.Data;
using Microsoft.AspNetCore.Mvc;
using API_PRUEBA_PROGRESO3.Models;
using Microsoft.EntityFrameworkCore;


namespace API_PRUEBA_PROGRESO3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {

        private readonly ApplicationDBContext _dbContext;

        public TareaController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<TareaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Tarea> tareas = await _dbContext.Tarea.ToListAsync();

            return Ok(tareas);
        }

        // GET api/<TareaController>
        [HttpGet("{idTarea}")]
        public async Task<IActionResult> Get(int idTarea)
        {
            Tarea tareaEncontrada = await _dbContext.Tarea.FirstOrDefaultAsync(data => data.idTarea == idTarea);

            return tareaEncontrada == null ? BadRequest() : Ok(tareaEncontrada);
        }

        // POST api/<TareaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Tarea newTarea)
        {

            Tarea tareaEncontrada = await _dbContext.Tarea.FirstOrDefaultAsync(x => x.idTarea == newTarea.idTarea);

            if (newTarea == null || tareaEncontrada != null)
            {
                return BadRequest("La nueva tarea tiene errores o ya existe la tarea a registrar");
            }

            await _dbContext.Tarea.AddAsync(newTarea);
            await _dbContext.SaveChangesAsync();

            return Ok(newTarea);
        }

        // PUT api/<TareaController>/5
        [HttpPut("{idTareaEditar}")]
        public async Task<IActionResult> Put(int idTareaEditar, [FromBody] Tarea newTarea)
        {
            Tarea tareaEditar = await _dbContext.Tarea.FirstOrDefaultAsync(data => data.idTarea == idTareaEditar);

            if (newTarea == null || tareaEditar == null)
            {
                return BadRequest("La tarea tiene errores o no existe la tarea a editar");
            }

            tareaEditar.nombreTarea = newTarea.nombreTarea == null ? tareaEditar.nombreTarea: newTarea.nombreTarea;
            tareaEditar.descripcionTarea = newTarea.descripcionTarea == null ? tareaEditar.descripcionTarea : newTarea.descripcionTarea;
            tareaEditar.estadoTarea = newTarea.estadoTarea == null ? tareaEditar.estadoTarea : newTarea.estadoTarea;

            await _dbContext.SaveChangesAsync();

            return Ok(tareaEditar);
        }

        // DELETE api/<TareaController>/5
        [HttpDelete("{idTareaEliminar}")]
        public async Task<IActionResult> Delete(int idTareaEliminar)
        {

            Tarea tareaEliminar = await _dbContext.Tarea.FirstOrDefaultAsync(data => data.idTarea == idTareaEliminar);

            if (tareaEliminar == null)
            {
                return BadRequest();
            }

            _dbContext.Remove(tareaEliminar);

            await _dbContext.SaveChangesAsync();

            return Ok("La tarea ha sido eliminado correctamente");
        }
    }
}

