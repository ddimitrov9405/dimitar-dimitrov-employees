using static dimitar_dimitrov_employees.Helpers.DateTimeHelper;

namespace dimitar_dimitrov_employees.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public int ProjectID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public bool IsOverlaping(Employee other)
        {
            return (this.ProjectID == other.ProjectID) &&
                   ((other.DateFrom <= this.DateFrom && this.DateFrom <= other.DateTo) ||
                   (this.DateFrom <= other.DateFrom && other.DateFrom <= this.DateTo));
        }

        public TimeSpan GetOverlapingDuration(Employee other)
        {
            return MinDateTime(this.DateTo, other.DateTo) - MaxDateTime(this.DateFrom, other.DateFrom);
        }
    }
}
