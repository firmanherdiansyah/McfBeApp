using McfBeApp.Api.Data;
using McfBeApp.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace McfBeApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BpkpTransactionController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public BpkpTransactionController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddBpkpTransaction(BpkpTransaction transaction) 
        {
           await _dbContext.AddAsync(transaction);
           var result = await _dbContext.SaveChangesAsync();

            if (result > 0)
                return Ok();

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
