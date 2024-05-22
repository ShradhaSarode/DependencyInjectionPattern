using DIDemo.Models;

namespace DIDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmployee(Employee employee);
        int DeleteEmployee(int id);

    }
}
