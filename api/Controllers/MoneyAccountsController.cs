using api.Helpers;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoneyAccountsController : ControllerBase
    {
        private readonly ILogger<MoneyAccountsController> _logger;
        private readonly IMoneyAccountRepository _moneyAccountRepository;

        public MoneyAccountsController(
            IMoneyAccountRepository moneyAccountRepository,
            ILogger<MoneyAccountsController> logger)
        {
            _moneyAccountRepository = moneyAccountRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var moneyAccounts = await _moneyAccountRepository.GetAsync();
                return Ok(moneyAccounts);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateFinanceGoalDto createFinanceGoalDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    try
        //    {
        //        var financeGoalModel = createFinanceGoalDto.ToFinanceGoalFromCreateFinanceGoalDto();
        //        await _financeGoalRepository.CreateAsync(financeGoalModel);

        //        return Created();
        //    }
        //    catch (NotFoundException)
        //    {
        //        return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateAsync(int id, [FromBody] UpdateFinanceGoalDto updateFinanceGoalDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    try
        //    {
        //        var financeGoal = updateFinanceGoalDto.ToFinanceGoalFromUpdateFinanceGoalDto();
        //        await _financeGoalRepository.UpdateAsync(id, financeGoal);

        //        return Ok();
        //    }
        //    catch (NotFoundException)
        //    {
        //        return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAsync(int id)
        //{
        //    try
        //    {
        //        await _financeGoalRepository.DeleteAsync(id);

        //        return Ok();
        //    }
        //    catch (NotFoundException)
        //    {
        //        return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

    }
}
