using Microsoft.AspNetCore.Mvc;
using Sozinho03.Domain.Model;

namespace Sozinho03.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public void Disable(Employee employee)
        {
            var EmployeeId = _context.Employees.Find(employee.id);
            EmployeeId.Disable();
            _context.SaveChanges();
        }

        public List<Employee> GetActive()
        {
            return _context.Employees.Where(e => e.activen).ToList();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Update([FromForm]Employee employee)
        {
            var EmployeeId = _context.Employees.Find(employee.id);

            EmployeeId.Up(employee.name, employee.age, employee.photo);
            _context.SaveChanges();
        }

    }
}
