using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private readonly ILogger<UsuarioController> _logger;

    private readonly IUsuarioRepositorio repository;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
        repository = new UsuarioRepositorio();
    }

    [HttpPost]
    [Route("CrearUsuario")]
    public ActionResult<Usuario> CrearUsuario(Usuario usuario)
    {
        repository.Create(usuario);
        return Ok("El usuario fue creado con exito" + usuario);
    }

    [HttpGet]
    [Route("ListarUsuario")]
    public ActionResult<List<Usuario>> ListarUsuario()
    {
        var usuarios = repository.GetAll();
        if (usuarios == null)
        {
            return BadRequest("No se pudo listar ningun usuario");
        }
        else
        {
            return Ok("Usuarios listados: " + usuarios);
        }
    }

    [HttpGet]
    [Route("BuscarUsuarioPorID")]
    public ActionResult<Usuario> BuscarPorID(int id)
    {
        var usuario = repository.GetUsuario(id);
        if (usuario == null)
        {
            return BadRequest("No se pudo listar al usuario");
        }
        else
        {
            return Ok("Usuario listado: " + usuario);
        }
    }

    [HttpPut]
    [Route("ModificarUsuario")]
    public ActionResult<Usuario> ModificarUsuario(int id, Usuario usuario)
    {
        repository.Set(id, usuario);
        return Ok("El usuario fue modificado con exito" + usuario);
    }

}