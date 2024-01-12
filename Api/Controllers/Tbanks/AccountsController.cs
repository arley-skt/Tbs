using Api.ViewModel;
using AutoMapper;
using Data.Domain;
using Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace Api.Controllers.Tbanks
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountsController(IAccountRepository produtoRepository, IMapper mapper)
        {
            _accountRepository = produtoRepository;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("AuthenticateToke")]
        public async Task<ActionResult<AccountViewModel>> Authenticate([FromBody] UserViewModel AccountTokenViewModel )
        {
            if (!ModelState.IsValid) return BadRequest();

            var Tok = new AccountTokenViewModel { Token = Guid.NewGuid(),TokenRefresh = Guid.NewGuid() };

            return Ok(Tok);
        }

        [HttpPost]
        public async Task<ActionResult<AccountViewModel>> OpenAccount([FromBody] AccountViewModel AccountViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var Accoun = _mapper.Map<AccountViewModel>(await _accountRepository.Adicionar(_mapper.Map<Produto>(AccountViewModel)));           

            return Ok();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AccountViewModel>> Getbankinfo(Guid id)
        {
            var Account = _mapper.Map<AccountViewModel>(await _accountRepository.ObterId(id));

            return Account;
        }

        [HttpPost]
        [Route("GetMoviments")]
        public async Task<ActionResult<AccountViewModel>> GetMoviments([FromBody] AccountViewModel MovimentsViewModel)
        {
            var Moviments = _mapper.Map<AccountViewModel>(await _accountRepository.ObterId(Guid.NewGuid()));

            return MovimentsViewModel;
        }
    }


}
