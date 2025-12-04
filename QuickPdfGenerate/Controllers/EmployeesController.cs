using Microsoft.AspNetCore.Mvc;
using QuickPdfGenerate.iRepository;

namespace QuickPdfGenerate.Controllers
{
    public class EmployeesController : Controller
    {
        IEmployeeRepository _employeeRepository = null;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ActionResult Employees()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return Json(employees);
        }
    }
}
