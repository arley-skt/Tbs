using Api.ViewModel;
using AutoMapper;
using Data.Domain;
using Data.Interface;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers.Tbanks
{
    [Route("api/[controller]")]
    [ApiController]
    public class PixOutController : ControllerBase
    {

        private readonly IPixOutRepository _pixOutRepository;
        private readonly IMapper _mapper;

        public PixOutController(IPixOutRepository fornecedorRepository, IMapper mapper)
        {
            _pixOutRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<PixOutViewModel>> Searchpixkey(Guid id)
        {
            //var fornecedor = _mapper.Map<FornecedorViewModel>(await _pixOutRepository.ObterPorId(id));

            //if (fornecedor == null) return NotFound();

            return Ok();
        }

        [HttpGet("{Nome}")]
        public async Task<ActionResult<PixOutViewModel>> Createpaymentorder(string Nome)
        {
            //var fornecedor = _mapper.Map<FornecedorViewModel>(await _pixOutRepository.ObterPorNome(Nome));

            //if (fornecedor == null) return NotFound();

            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult<PixOutViewModel>> Getbalance([FromBody] PixOutViewModel balanceViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var Balance = _mapper.Map<PixOutViewModel>(await _pixOutRepository.Adicionar(_mapper.Map<Fornecedor>(balanceViewModel)));

            return balanceViewModel;
        }


    }
}
