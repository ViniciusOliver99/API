using Microsoft.AspNetCore.Mvc;
using Sozinho03.Aplication.ViewModel;
using Sozinho03.Domain.Model;

namespace Sozinho03.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public AdminController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _employeeRepository.GetAll();
            return Ok(employee);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Disable(int id)
        {
            var employee = _employeeRepository.GetById(id);

            employee.Disable();
            _employeeRepository.Disable(employee);
            return Ok(employee);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id) 
        {
            _employeeRepository.Delete(id);
            return Ok();
        }


    }
}
