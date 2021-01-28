using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    public class Paging 
    {
       public pagedetails pagination { get; set; }
            public class pagedetails
            {
                public string total { get; set; }
                public string pages { get; set; }
                public string page { get; set; }
                public string limit { get; set; }
            }
    }
}
