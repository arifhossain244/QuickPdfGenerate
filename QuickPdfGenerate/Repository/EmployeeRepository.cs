using QuickPdfGenerate.iRepository;
using QuickPdfGenerate.Models;

namespace QuickPdfGenerate.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Abdur", Salary = 1250000, Designation = "CEO" });
            employees.Add(new Employee { Id = 2, Name = "Nishita", Salary = 3250000, Designation = "Co-CEO" });
            employees.Add(new Employee { Id = 3, Name = "Mizanur", Salary = 250000, Designation = "Team Leader" });
            employees.Add(new Employee { Id = 4, Name = "Sourav", Salary = 220000, Designation = "Architect" });
            employees.Add(new Employee { Id = 5, Name = "Zubayed", Salary = 195000, Designation = "Senior Team Developer" });
            employees.Add(new Employee { Id = 6, Name = "Sahadat", Salary = 190000, Designation = "Senior Co-Team Developer" });
            employees.Add(new Employee { Id = 7, Name = "Imran", Salary = 85000, Designation = "HR Manager" });
            employees.Add(new Employee { Id = 8, Name = "Rasel", Salary = 55000, Designation = "Jr. Developer" });
            employees.Add(new Employee { Id = 9, Name = "Anamul", Salary = 49000, Designation = "Jr. Co-Developer & Sr. Software QA" });
            employees.Add(new Employee { Id = 10, Name = "Arif", Salary = 40000, Designation = "Sr. Software QA" });
            employees.Add(new Employee { Id = 11, Name = "Rony", Salary = 19000, Designation = "Office-Assistant" });
            employees.Add(new Employee { Id = 12, Name = "Female_cook", Salary = 4000, Designation = "Cooker" });
            return employees;
        }
    }
}
