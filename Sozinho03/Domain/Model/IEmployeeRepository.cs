using Sozinho03.Aplication.ViewModel;

namespace Sozinho03.Domain.Model
{
    public interface IEmployeeRepository
    {
        //Admin
        List<Employee> GetAll();

        //Users
        List<Employee> GetActive();
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Disable(Employee employee);
        void Delete(int id);
    }
}
