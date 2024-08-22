using Microsoft.AspNetCore.Mvc;
using Sozinho03.Aplication.ViewModel;
using Sozinho03.Domain.Model;

namespace Sozinho03.Controllers.v1
    {
        [ApiController]
        [Route("api/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetActive()
        {
            var employee = _employeeRepository.GetActive();
            return Ok(employee);
        }
        [HttpGet]
        [Route("id")]
        public IActionResult GetById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Add([FromForm]EmployeeViewModel employeeView)
        {
            var employees = new Employee(employeeView.name, employeeView.age, employeeView.photo);
            _employeeRepository.Add(employees);
            return Ok(employeeView);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromForm] EmployeeViewModel employeeView)
        {

            var employeeId = _employeeRepository.GetById(id);
            employeeId.Up(employeeView.name, employeeView.age, employeeView.photo);
            _employeeRepository.Update(employeeId);
            return Ok(employeeId);
        }

    }
}
