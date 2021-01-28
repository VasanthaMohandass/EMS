using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmEmployee : Form
    {

        public int currentPage { get; set; }
        public int MaxPage { get; set; }
        public string AppName = ConfigurationManager.AppSettings["AppName"]; //"fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56"; 
        public frmEmployee()
        {
            InitializeComponent();
            RESTApiHelper.InitializeClient();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnGo.Enabled = false;

        }

        #region UI Events

        /// <summary>
        /// Event to handle ListAll Employees to populate all employee details
        /// </summary>
        private void btnListAll_Click(object sender, EventArgs e)
        {
            ListAllEmployees();

        }

        /// <summary>
        ///Event to handle Employee search by Id and populate the employee details
        /// </summary>
        private async void btnIDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEmpIDControl((Button)sender))
                 { 
                    string response = await RESTApiHelper.Get(txtEmpID.Text.Trim());
                    DeserializeJsonforSingleSearch(response);
                }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
}

        /// <summary>
        ///Event to handle Employee search by Name and populate the employee details
        /// </summary>
        private async void btnNameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtEmpName.Text.Length > 0))
                {
                    txtEmpName.Focus();
                    MessageBox.Show("Please enter Name", AppName);
                    return;
                }
                var response = await RESTApiHelper.Get(txtEmpName.Text.Trim());
                var jsonparse = JsonConvert.DeserializeObject<JsonResponse>(response);
                dgvEmployee.DataSource = jsonparse.data;
                if (dgvEmployee.Rows.Count > 0)
                {
                    LoadControls(0);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
}

        /// <summary>
        /// Event to handle to clear the employee details from the user input controls
        /// </summary>
        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        /// <summary>
        /// Event to handle adding new employee
        /// </summary>
        private async void btnEmpAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls((Button)sender))
                {
                    EmployeeAdd newEmployee = new EmployeeAdd();
                    newEmployee.name = txtEmpName.Text.Trim();
                    newEmployee.email = txtEmpEmail.Text.Trim();
                    newEmployee.gender = cboEmpGender.SelectedItem.ToString();
                    newEmployee.status = cboEmpStatus.SelectedItem.ToString();
                    var response = await RESTApiHelper.Post(newEmployee);
                    //DeserializeJsonforSingleSearch(response);
                    LoadCurrentPage(Convert.ToInt32(lblPages.Text));
                    //ListAllEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }

}

        /// <summary>
        /// Event to handle updating an employee
        /// </summary>
        private async void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls((Button)sender))
                {
                    Employee updEmployee = new Employee();
                    updEmployee.id = txtEmpID.Text.Trim();
                    updEmployee.name = txtEmpName.Text.Trim();
                    updEmployee.email = txtEmpEmail.Text.Trim();
                    updEmployee.gender = cboEmpGender.SelectedItem.ToString();
                    updEmployee.status = cboEmpStatus.SelectedItem.ToString();
                    var response = await RESTApiHelper.Put(updEmployee);   //FormJsonString());
                    LoadCurrentPage(Convert.ToInt32(lblcurrPage.Text));
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }
        }

        /// <summary>
        /// Event to handle deleting an employee
        /// </summary>
        private async void btnEmpDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (ValidateEmpIDControl((Button)sender))
                {
                    var response = await RESTApiHelper.Delete(FormJsonString());
                    LoadCurrentPage(Convert.ToInt32(lblcurrPage.Text));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }
        }

        /// <summary>
        /// Event to handle Page no search for datagridview
        /// </summary>
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtPageNo.Text.Length > 0))
                {
                    txtPageNo.Focus();
                    MessageBox.Show("Please enter valid PageNo.", AppName);
                    txtPageNo.Text = lblcurrPage.Text;
                    return ;
                }
                currentPage = Convert.ToInt32(txtPageNo.Text);
                MaxPage = Convert.ToInt32(lblPages.Text); 
                if (currentPage > MaxPage)
                {
                    btnNext.Enabled = false;
                    LoadCurrentPage(MaxPage);
                }
                else
                {
                    if (currentPage > 1)
                    {
                        btnPrevious.Enabled = true;
                    }
                    LoadCurrentPage(currentPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }
        }

        /// <summary>
        /// Event to handle Previous button click for datagridview
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                    currentPage = Convert.ToInt32(txtPageNo.Text);
                if (currentPage > 1)
                {
                    currentPage -= 1;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    LoadCurrentPage(currentPage);
                }
                else
                {
                    btnPrevious.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }

}

        /// <summary>
        /// Event to handle Next button click for datagridview
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                currentPage = Convert.ToInt32(txtPageNo.Text);
                MaxPage = Convert.ToInt32(lblPages.Text); 
                if (currentPage < MaxPage)
                {
                    currentPage += 1;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    LoadCurrentPage(currentPage);
                }
                else
                {
                    btnNext.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }
        }
        
        /// <summary>
        /// Event to handle clicking a row in datagridview and populating the controls with selected employee details
        /// </summary>
        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                if (dgvEmployee.Rows.Count > 0)
                {
                    LoadControls(index);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
        }

        /// <summary>
        /// Event to allow only numeric value in pageno textbox
        /// </summary>
        private void txtPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// Event to allow only numeric value in Employee ID textbox
        /// </summary>
        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        #endregion


        #region UserDefined Functions


        /// <summary>
        /// //Call APIHelper to get all employees and load datagridview
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        private async void ListAllEmployees()
        {
            try
            {
                var response = await RESTApiHelper.GetAll();
                JsonResponse jsonparse = JsonConvert.DeserializeObject<JsonResponse>(response);
                dgvEmployee.DataSource = jsonparse.data;
                txtPageNo.Text = jsonparse.meta.pagination.page;
                lblcurrPage.Text = jsonparse.meta.pagination.page;
                txtTotalRec.Text = jsonparse.meta.pagination.total;               
                lblPages.Text = jsonparse.meta.pagination.pages;
                if (dgvEmployee.Rows.Count > 0)
                {
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = true;
                    LoadControls(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);

            }
        }

        /// <summary>
        /// //Call APIHelper to get current page and load datagridview
        /// </summary>
        /// <param>current pageno</param>
        /// <returns></returns>
        private async void LoadCurrentPage(int currentPage)
        {
            try
            {
                var response = await RESTApiHelper.GetPage(currentPage.ToString());
                JsonResponse jsonparse = JsonConvert.DeserializeObject<JsonResponse>(response);
                dgvEmployee.DataSource = jsonparse.data;
                txtPageNo.Text = jsonparse.meta.pagination.page;
                lblcurrPage.Text = jsonparse.meta.pagination.page;
                txtTotalRec.Text = jsonparse.meta.pagination.total;                
                lblPages.Text = jsonparse.meta.pagination.pages;
                if (dgvEmployee.Rows.Count > 0)
                {
                    LoadControls(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,AppName);
            }
        }

        /// <summary>
        /// //Function to load user input controls from datatgridview
        /// </summary>
        /// <param>selected row index</param>
        /// <returns></returns>
        private void LoadControls(int index)
        {
            try
            {
                btnGo.Enabled = true;
                txtEmpID.Text = dgvEmployee.Rows[index].Cells[0].Value.ToString();
                txtEmpName.Text = dgvEmployee.Rows[index].Cells[1].Value.ToString();
                txtEmpEmail.Text = dgvEmployee.Rows[index].Cells[2].Value.ToString();
                cboEmpGender.Text = dgvEmployee.Rows[index].Cells[3].Value.ToString();
                if (cboEmpGender.Text.Trim().ToUpper() == "MALE")
                {
                    cboEmpGender.SelectedIndex = 0;
                }
                else
                {
                    cboEmpGender.SelectedIndex = 1;

                }
                cboEmpStatus.Text = dgvEmployee.Rows[index].Cells[4].Value.ToString();
                if (cboEmpStatus.Text.Trim().ToUpper() == "ACTIVE")
                {
                    cboEmpStatus.SelectedIndex = 0;
                }
                else
                {
                    cboEmpStatus.SelectedIndex = 1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
        }

        /// <summary>
        /// //Function to clear userinput controls
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        private void ClearControls()
        {
            try
            { 
                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtEmpEmail.Text = "";
                cboEmpGender.Text = "";
                cboEmpStatus.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
        }

        /// <summary>
        /// //Form Jsonstring for Delete request
        /// </summary>
        /// <param></param>
        /// <returns>employee</returns>
        private Employee FormJsonString()
        {
            Employee jsonEmp = null; 
            string strGender = string.Empty;
            string strStatus = string.Empty;
            try
            {
                if (cboEmpGender.SelectedIndex > -1)
                {
                    strGender = cboEmpGender.SelectedItem.ToString();
                }
                if (cboEmpStatus.SelectedIndex > -1)
                {
                    strStatus = cboEmpStatus.SelectedItem.ToString();
                }

                jsonEmp = new Employee
                {
                    id = txtEmpID.Text.Trim(),
                    name = txtEmpName.Text.Trim(),
                    email = txtEmpEmail.Text.Trim(),
                    gender = strGender,
                    status = strStatus
                };
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
            return jsonEmp;
        }

        /// <summary>
        /// //Deserialize the response to get one record of employee
        /// </summary>
        /// <param>search response</param>
        /// <returns></returns>
        private void DeserializeJsonforSingleSearch(string response)
        {
            try
            {
                var jsonparse = JsonConvert.DeserializeObject<JsonResponseSearch>(response);
                if (jsonparse.code == "404")
                {
                    MessageBox.Show("Not Found", AppName);
                    return;
                }
                Employee objEmp = new Employee();
                objEmp.id = jsonparse.data.id;
                objEmp.name = jsonparse.data.name;
                objEmp.email = jsonparse.data.email;
                objEmp.gender = jsonparse.data.gender;
                objEmp.status = jsonparse.data.status;
                var ds = new BindingList<Employee>();
                dgvEmployee.DataSource = ds;
                ds.Add(objEmp);
                if (dgvEmployee.Rows.Count > 0)
                {
                    LoadControls(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
            }
        }

        /// <summary>
        /// //Validate user input controls based on button click
        /// <param>pass the button that is clicked</param>
        /// <returns>bool</returns>
        ///  </summary>
        private bool ValidateControls(Button btnclicked)
        {
            if (!ValidateEmpIDControl(btnclicked))
                return false;

            if (!(txtEmpName.Text.Length > 0))
            {
                txtEmpName.Focus();
                MessageBox.Show("Please enter Name", AppName);
                return false;
            }
            if (!(txtEmpEmail.Text.Length > 0))
            {
                txtEmpEmail.Focus();
                MessageBox.Show("Please enter email", AppName);
                return false;
            }
            if (cboEmpGender.SelectedIndex == -1)
            {
                cboEmpGender.Focus();
                MessageBox.Show("Please select Gender", AppName);
                return false;
            }
            if (cboEmpStatus.SelectedIndex == -1)
            {
                cboEmpStatus.Focus();
                MessageBox.Show("Please select Gender", AppName);
                return false;
            }

            if (!(string.IsNullOrWhiteSpace(txtEmpEmail.Text)))
            {
                string strEmail = txtEmpEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(strEmail);
                if (!match.Success)
                {
                    txtEmpEmail.Focus();
                    MessageBox.Show("Please enter valid email address", AppName);
                    return false;
                }
            }
            return true;

        }

        /// <summary>
        /// //Validate employee id textbox based on button click
        /// </summary>
        /// <param>pass the button that is clicked</param>
        /// <returns>bool</returns>
        private bool ValidateEmpIDControl(Button btnclicked)
        {
            if ((btnclicked.Text == btnIDSearch.Text) || (btnclicked.Text == btnEmpUpdate.Text) || (btnclicked.Text == btnEmpDelete.Text))
            {
                if (!(txtEmpID.Text.Length > 0))
                {
                    txtEmpID.Focus();
                    MessageBox.Show("Please enter Employee ID", AppName);
                    return false;
                }
            }
            return true;
        }

        #endregion
        
    }
}
