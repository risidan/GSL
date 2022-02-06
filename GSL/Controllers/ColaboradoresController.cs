using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GSL.Controllers
{
    public class ColaboradoresController : ApiController
    {

        private readonly IColaboradoresService _service;
        public ColaboradoresController(IColaboradoresService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(List<ColaboradorVM>), 200)]
        public async Task<IActionResult> Get()
        {
            return CustomResponse(await _service.GetAll());
        }

        [HttpGet("{idColaborador}")]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(ColaboradorVM), 200)]
        public async Task<IActionResult> GetById(Guid idColaborador)
        {
            return CustomResponse(await _service.GetById(idColaborador));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> Create([FromBody] ColaboradorVM colaboradorVM)
        {
            return CustomResponse(await _service.Create(colaboradorVM));
        }

        [HttpGet]
        [Route("infos")]
        [Authorize(Roles = "colaborador")]
        public string AreaLogadaColaborador() => String.Format("Bem-vindo Colaborador - {0}", User.Identity.Name);

    }
}
