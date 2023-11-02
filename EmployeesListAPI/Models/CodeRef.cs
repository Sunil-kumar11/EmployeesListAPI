﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesListAPI.Models
{
    [PrimaryKey(nameof(CodeType), nameof(Code))]
    public class CodeRef
    {
        public string CodeType { get; set; }
        
        public string Code { get; set; }
        public string? Title { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
