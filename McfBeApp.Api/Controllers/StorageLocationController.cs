using McfBeApp.Api.Data;
using McfBeApp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace McfBeApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StorageLocationController : ControllerBase
    {

        private readonly ApplicationDBContext _dbContext;

        public StorageLocationController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetStorageLocation")]
        public IActionResult Get() =>
            new JsonResult(_dbContext.StorageLocation.ToList(), new JsonSerializerOptions { PropertyNamingPolicy = null });
    }
}
