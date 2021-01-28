using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{   
    public class Employee
    {
        [DisplayName("EmployeeID")]
        public string id { get; set; }
        [DisplayName("EmployeeName")]
        public string name { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        [DisplayName("Status")]
        public string status { get; set; }
    }

    public class EmployeeAdd
    {
        
        [DisplayName("EmployeeName")]
        public string name { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        [DisplayName("Status")]
        public string status { get; set; }
    }
}
