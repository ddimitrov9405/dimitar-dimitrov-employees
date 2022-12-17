using dimitar_dimitrov_employees.Models;
using static dimitar_dimitrov_employees.Constants.Constants;

namespace dimitar_dimitrov_employees.Services
{
    public class ReadFileService : IReadFileService
    {
        public List<Employee> ReadEmployeesFromFile(IFormFile file)
        {
            var result = new List<Employee>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    var data = reader.ReadLine().Split(',');
                    result.Add(new Employee
                    {
                        EmpID = int.Parse(data[0].Trim()),
                        ProjectID = int.Parse(data[1].Trim()),
                        DateFrom = DateTime.Parse(data[2].Trim()),
                        DateTo = data[3].Trim() != NullValue ? DateTime.Parse(data[3].Trim()) : DateTime.Now

                    });
                }
            }
            return result;
        }
    }
}
