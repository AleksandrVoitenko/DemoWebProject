using AutoMapper;
using Debtors.Application.Debtors.Commands.ClearDebtorsTrash;
using Debtors.Application.Debtors.Commands.CreateDebtors;
using Debtors.Application.Debtors.Commands.EditDebtor;
using Debtors.Application.Debtors.Commands.RemoveDebtor;
using Debtors.Application.Debtors.Queries.GetDebtorDetails;
using Debtors.Application.Debtors.Queries.GetDebtorsList;
using Debtors.WebApi.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Debtors.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DebtorController : BaseController
    {
        private readonly IMapper _mapper;

        public DebtorController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<DebtorsListVm>> GetAll()
        {
            var query = new GetDebtorsListQuery()
            {
                UserId = UserId
            };
            var viewModel = await Mediator.Send(query);
            return Ok(viewModel);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DebtorDetailsVm>> Get(Guid id)
        {
            var query = new GetDebtorDetailsQuery()
            {
                Id = id,
                UserId = UserId
            };
            var viewModel = await Mediator.Send(query);
            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateDebtorDto createDebtorDto)
        {
            var command = _mapper.Map<CreateDebtorCommand>(createDebtorDto);
            command.UserID = UserId;
            var debtorId = await Mediator.Send(command);
            return Ok(debtorId);
        }

        [HttpPut]
        public async Task<IActionResult> EditDebtor([FromBody] EditDebtorDto editDebtorDto)
        {
            var command = _mapper.Map<EditDebtorCommand>(editDebtorDto);
            command.UserId = UserId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> RemoveDebtor(Guid id)
        {
            var command = new RemoveDebtorCommand()
            {
                Id = id,
                UserId = UserId
            };
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> ClearDebtorsTrash()
        {
            var command = new ClearDebtorsTrashCommand()
            {
                UserId = UserId
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
