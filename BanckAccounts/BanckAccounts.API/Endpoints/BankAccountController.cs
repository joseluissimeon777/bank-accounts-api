using BankAccounts.API.Application.Commands.Deposits;
using BankAccounts.API.Application.Commands.WithDraws;
using BankAccounts.API.Application.Queries.GetAllAccounts;
using BankAccounts.API.Application.Queries.GetBalanceAccount;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.API.Endpoints
{
    [Route("api/v1/bank-accounts")]
    public class BankAccountController(ISender sender) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllAccountsQuery();

            var result = await sender.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}/balance")]
        public async Task<IActionResult> GetBalance(Guid id)
        {
            var query = new GetBalanceAccountQuery(id);

            var result = await sender.Send(query);

            if (result.IsFailure)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("{id}/deposit")]
        public async Task<IActionResult> Deposit(Guid id, [FromBody] decimal amount)
        {
            var command = new DepositCommand(id, amount);

            var result = await sender.Send(command);

            if (result.IsFailure)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("{id}/withdraw")]
        public async Task<IActionResult> WithDraw(Guid id, [FromBody] decimal amount)
        {
            var command = new WithDrawCommand(id, amount);

            var result = await sender.Send(command);

            if (result.IsFailure)
                return BadRequest(result);

            return Ok(result);
        }


    }
}
