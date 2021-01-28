using EmployeeManagementSystem.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagementSystem.Shared
{
    public class RESTApiHelper
    {

        public static readonly string baseURL = ConfigurationManager.AppSettings["BaseURL"]; 
        public static string APItoken = ConfigurationManager.AppSettings["ApiToken"]; //"fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56"; 
        public static int MaxPages{ get; set; }
        public static HttpClient client { get; set; }

        public static void InitializeClient()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region API calls
        /// <summary>
        /// API Service call to get all employees
        /// </summary>
        /// <param></param>
        /// <returns>List of Employees as API response</returns>
        public static async Task<string> GetAll()
        {
            using (client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "users"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                
                                return employeeJsonString;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }

            }
            return string.Empty;
        }

        /// <summary>
        /// API Service call to get list of employees forthe  provided pageno
        /// </summary>
        /// <param name="string"></param>
        /// <returns>List of Employees as API response</returns>
        public static async Task<string> GetPage(string inputStr)
        {
            using (client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "users?page=" + inputStr))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                return employeeJsonString;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }

            }
            return string.Empty;
        }


        /// <summary>
        /// API Service call to search employee by Id or Name
        /// </summary>
        /// <param name="string"></param>
        /// <returns>List of Employes API response</returns>
        public static async Task<string> Get(string inputStr)
        {
            string searchurl = baseURL;
            if (inputStr.All(char.IsDigit))
            {
                searchurl = searchurl + "users/" + inputStr; // Search with employeeid
            }
            else
            {
                searchurl = searchurl + "users?name=" + inputStr;// Search with employee name
            }
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(searchurl))
                {
                    using (HttpContent content = response.Content)
                    {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                return employeeJsonString;
                            }                           
                    }
                }

            }
            return string.Empty;

        }

        /// <summary>
        /// API Service call to add employee
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns>Added API response</returns>
        public static async Task<string> Post(EmployeeAdd newEmployee)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APItoken);
                using (HttpResponseMessage response = await client.PostAsJsonAsync<EmployeeAdd>(baseURL + "users" + "?api_key = " + APItoken, newEmployee))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                return employeeJsonString;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }

            }
            return string.Empty;
        }

        /// <summary>
        /// API Service call to update employee
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns>updated API response</returns>
        public static async Task<string> Put(Employee updEmployee)
        {
            using (client = new HttpClient())
            {                
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APItoken);
                using (HttpResponseMessage response = await client.PutAsJsonAsync<Employee>(baseURL + "users/" + updEmployee.id + "?api_key = " + APItoken, updEmployee))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                return employeeJsonString;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }

            }
            return string.Empty;
        }       

        /// <summary>
        /// API Service call to delete employee
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns></returns>
        public static async Task<string> Delete(Employee delEmployee)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APItoken);
                using (HttpResponseMessage response = await client.DeleteAsync(baseURL + "users/" + delEmployee.id + "?api_key = "+ APItoken))
                { 
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string employeeJsonString = await content.ReadAsStringAsync();
                            if (employeeJsonString != null)
                            {
                                return employeeJsonString;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }

            }
            return string.Empty;
        }
        #endregion 

    }

}
