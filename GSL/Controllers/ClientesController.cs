using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GSL.Controllers
{
    //[AllowAnonymous]
    public class ClientesController : ApiController
    {
        private readonly IClientesService _service;
        public ClientesController(IClientesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(List<ClienteVM>), 200)]
        public async Task<IActionResult> Get()
        {
            return CustomResponse(await _service.GetAll());
        }

        [HttpGet("{idCliente}")]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(ClienteVM), 200)]
        public async Task<IActionResult> GetById(Guid idCliente)
        {
            return CustomResponse(await _service.GetById(idCliente));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> Create([FromBody] ClienteVM clienteVM)
        {
            return CustomResponse(await _service.Create(clienteVM));
        }

        [HttpGet]
        [Route("infos")]
        [Authorize(Roles = "cliente")]
        public string AreaLogadaColaborador() => String.Format("Bem-vindo Cliente - {0}", User.Identity.Name);

    }
}
