using dimitar_dimitrov_employees.Models;

namespace dimitar_dimitrov_employees.Services
{
    public class OrderEmplyeesService : IOrderEmplyeesService
    {
        public WorkedTogetherResult GetLongestTimeWorkedTogether(List<Employee> employees)
        {
            var result = new WorkedTogetherResult();

            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].IsOverlaping(employees[j]))
                    {
                        var duration = employees[i].GetOverlapingDuration(employees[j]);

                        if (result.Duration < duration)
                        {
                            result.Duration = duration;
                            result.Employee1Id = employees[i].EmpID;
                            result.Employee2Id = employees[j].EmpID;
                            result.ProjectId = employees[i].ProjectID;
                        }
                    }
                }
            }

            return result;
        }
    }
}
