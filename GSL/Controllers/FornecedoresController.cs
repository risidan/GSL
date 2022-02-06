using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GSL.Controllers
{
    public class FornecedoresController : ApiController
    {
        private readonly IFornecedoresService _service;
        public FornecedoresController(IFornecedoresService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(List<FornecedorVM>), 200)]
        public async Task<IActionResult> Get()
        {
            return CustomResponse(await _service.GetAll());
        }

        [HttpGet("{idCliente}")]
        [Authorize(Roles = "colaborador")]
        [ProducesResponseType(typeof(FornecedorVM), 200)]
        public async Task<IActionResult> GetById(Guid idFornecedor)
        {
            return CustomResponse(await _service.GetById(idFornecedor));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> Create([FromBody] FornecedorVM fornecedorVM)
        {
            return CustomResponse(await _service.Create(fornecedorVM));
        }

        [HttpGet]
        [Route("infos")]
        [Authorize(Roles = "fornecedor")]
        public string AreaLogadaColaborador() => String.Format("Bem-vindo Fornecedor - {0}", User.Identity.Name);

    }
}
