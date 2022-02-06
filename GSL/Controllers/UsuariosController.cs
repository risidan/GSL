using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GSL.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuariosService _service;
        public UsuariosController(IUsuariosService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> Create([FromBody] UsuarioVM usuario)
        {
            return CustomResponse(await _service.Authenticate(usuario));
        }

    }
}
