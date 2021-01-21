using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Hieu_iceTea.Models
{
    public class Employees
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Project { get; set; }
    }
}
