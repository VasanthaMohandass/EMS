using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    /*Response format
    * {
    * "code":200,
    * "meta":{
    *          "pagination":
        *          {
        *          "total":1516,
        *          "pages":76,
        *          "page":1,
        *          "limit":20
        *          }
    *          },
    * "data":[
    *          {"id":302,
    *          "name":"Mehrdad Tajedini",
    *          "email":"sdf@asd",
    *          "gender":"Male",
    *          "status":"Inactive",
    *          "created_at":"2021-01-26T03:50:08.030+05:30",
    *          "updated_at":"2021-01-26T21:08:42.323+05:30"
    *          }
    *         ]
    *  }
    */
    [Serializable]
    public class JsonResponse : Paging 
    {
        public string code { get; set; }
        public Paging meta { get; set; } 
        public List<empdata> data { get; set; }
       
        public class empdata
        {
            [DisplayName("EmployeeID")]
            public string id { get; set; }
            [DisplayName("EmployeName")]
            public string name { get; set; }
            [DisplayName("Email")]
            public string email { get; set; }
            [DisplayName("Gender")]
            public string gender { get; set; }
            [DisplayName("Status")]
            public string status { get; set; }
        }
    }

    [Serializable]
    public class JsonResponseSearch : Paging
    {
        public string code { get; set; }
        public Paging meta { get; set; }
        public empdata data { get; set; }

        public class empdata
        {
            [DisplayName("EmployeeID")]
            public string id { get; set; }
            [DisplayName("EmployeName")]
            public string name { get; set; }
            [DisplayName("Email")]
            public string email { get; set; }
            [DisplayName("Gender")]
            public string gender { get; set; }
            [DisplayName("Status")]
            public string status { get; set; }
        }
    }
}
