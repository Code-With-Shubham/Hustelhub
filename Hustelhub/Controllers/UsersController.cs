using HustelHub.BusinessArea.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hustelhub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepository objRep;
        private readonly IConfiguration _configuration;
        private readonly ILogger<UsersController> _logger;


        public UsersController(IRepository repository, IConfiguration configuration, ILogger<UsersController> logger)
        {
            _configuration = configuration;
            objRep = repository;
            _logger = logger;
            _logger.LogInformation("\n\nUsersController Logs : \n");

        }


    }
}
