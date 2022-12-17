using dimitar_dimitrov_employees.Models;
using dimitar_dimitrov_employees.Services;
using Microsoft.AspNetCore.Mvc;

namespace dimitar_dimitrov_employees.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IReadFileService _readFileService;
        private readonly IOrderEmplyeesService _orderEmplyeesService;

        public EmployeesController(IReadFileService readFileService, IOrderEmplyeesService orderEmplyeesService)
        {
            _readFileService = readFileService;
            _orderEmplyeesService = orderEmplyeesService;
        }

        //Using HttpPost as IFormFile is not working with HttpGet
        [HttpPost]
        [Route("GetWorkedTogether")]
        public WorkedTogetherResult GetWorkedTogether(IFormFile file)
        {
            var list = _readFileService.ReadEmployeesFromFile(file); ;
            return _orderEmplyeesService.GetLongestTimeWorkedTogether(list);
        }
    }
}
