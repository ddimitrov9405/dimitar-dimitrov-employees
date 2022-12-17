using dimitar_dimitrov_employees.Models;

namespace dimitar_dimitrov_employees.Services
{
    public interface IReadFileService
    {
        public List<Employee> ReadEmployeesFromFile(IFormFile file);
    }
}
