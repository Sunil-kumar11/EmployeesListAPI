using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesListAPI.Models
{
    [PrimaryKey(nameof(CompanyCode), nameof(EmpCode))]
    public class Employee
    {
        public string CompanyCode { get; set; }
       
        public string EmpCode { get; set; }
        public string EmployeeName { get; set; }
        public string AliasName { get; set; }
        public string? ICNO { get; set; }
        public string? SectionCode { get; set; }
        public string? DepartmentCode { get; set; }
        public string? DesignationCode { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
