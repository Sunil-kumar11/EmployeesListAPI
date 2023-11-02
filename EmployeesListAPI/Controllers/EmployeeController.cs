using EmployeesListAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EmployeesListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly BaseDbContext _baseDbContext;

        public EmployeeController(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
           var employees= await _baseDbContext.Employee.ToListAsync();
           var coderef= await _baseDbContext.CodeRef.ToListAsync();
            var Company=await _baseDbContext.Company.ToListAsync();
            var query = from employeedata in employees
                        select new
                        {
                            employeedata.EmpCode,
                            employeedata.EmployeeName,
                            employeedata.AliasName,
                            employeedata.ICNO,
                            employeedata.SectionCode,
                            Department = coderef.Where(x => x.Code == employeedata.DepartmentCode).Select(n => n.Title).FirstOrDefault(),
                            Designation = coderef.Where(x => x.Code == employeedata.DesignationCode).Select(n => n.Title).FirstOrDefault(),
                            status = employeedata.ResignDate <= DateTime.Now ? "Active Staff" : "Inactive",
                            companyname =Company.Where(x =>x.CompanyCode == employeedata.CompanyCode).Select(n => n.CompanyName).FirstOrDefault()

                        };
            
            var  dict= new Dictionary<string, object>();
            var  diction= new Dictionary<string, object>();
            diction.Add("employee", query);
            diction.Add("companyautocomplete", Company);
            dict.Add("message","successful" );
            dict.Add("responsecode","200" );
            dict.Add("data",diction);
            return Ok(dict);
        }
    }
}
