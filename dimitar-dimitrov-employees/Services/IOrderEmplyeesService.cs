using dimitar_dimitrov_employees.Models;

namespace dimitar_dimitrov_employees.Services
{
    public interface IOrderEmplyeesService
    {
        public WorkedTogetherResult GetLongestTimeWorkedTogether( List<Employee> employees);
    }
}
