using api.Helpers;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using shared.DTOs.Dropdown;
using shared.ENUMs;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DropdownController : ControllerBase
    {
        private readonly ILogger<DropdownController> _logger;
        private readonly IDropdownRepository _dropdownRepository;

        public DropdownController(
            IDropdownRepository dropdownRepository,
            ILogger<DropdownController> logger)
        {
            _dropdownRepository = dropdownRepository;
            _logger = logger;
        }

        [HttpGet("GetTypeOfAccounts")]
        public IActionResult GetTypeOfAccounts()
        {
            try
            {
                List<DropdownDto> result = new List<DropdownDto>()
                {
                    new() {Id=(int)TypeOfMoneyAccountEnum.BANK,Description=TypeOfMoneyAccountEnum.BANK.ToString()},
                    new() {Id=(int)TypeOfMoneyAccountEnum.CREDIT,Description=TypeOfMoneyAccountEnum.CREDIT.ToString()},
                    new() {Id=(int)TypeOfMoneyAccountEnum.CREDITCARD,Description=TypeOfMoneyAccountEnum.CREDITCARD.ToString()},
                    new() {Id=(int)TypeOfMoneyAccountEnum.DEBITCARD,Description=TypeOfMoneyAccountEnum.DEBITCARD.ToString()},
                    new() {Id=(int)TypeOfMoneyAccountEnum.GIFTCARD,Description=TypeOfMoneyAccountEnum.GIFTCARD.ToString()},
                };

                return Ok(result);
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
    }
}
