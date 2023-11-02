using System.ComponentModel.DataAnnotations;

namespace EmployeesListAPI.Models
{
    public class Company
    {
        [Key]
        public string CompanyCode { get; set; }

        public string CompanyName { get; set; }
    }
}
