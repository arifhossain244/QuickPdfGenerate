using QuickPdfGenerate.Models;

namespace QuickPdfGenerate.iRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
