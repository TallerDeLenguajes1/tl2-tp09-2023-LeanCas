using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{

    private readonly ILogger<TableroController> _logger;

    private readonly ITareaRepositorio repository;

    public TableroController(ILogger<TableroController> logger)
    {
        _logger = logger;
        repository = new TareaRepositorio();
    }

    [HttpPost]
    [Route("CrearTablero")]
    public ActionResult<Tarea> CrearUsuario(int idTablero)
    {
        var tarea = repository.Create(idTablero);
        return Ok("El tablero fue creado con exito" + tarea);
    }

    [HttpGet]
    [Route("ListarTableros")]
    public ActionResult<List<Tablero>> ListarTableros()
    {
        var tableros = repository.GetAll();
        if (tableros == null)
        {
            return BadRequest("No se pudo listar ningun tablero");
        }
        else
        {
            return Ok("Tableros listados: " + tableros);
        }
    }

}