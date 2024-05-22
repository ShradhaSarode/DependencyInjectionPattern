using DIDemo.Models;

namespace DIDemo.Repositories
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmployee(Employee employee);
        int DeleteEmployee(int id);


    }
}
