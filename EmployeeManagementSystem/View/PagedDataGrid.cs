using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Model;

namespace EmployeeManagement
{
    public class PagedDataGrid : DataGridView
    {

        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int PageNo { get; set; }
        public int _pageSize = 20; // Convert.ToInt32 (ConfigurationManager.AppSettings["GridPageSize"].ToString());

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        
                

        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();
        public void SetPagedDataSource(DataTable dataTable, BindingNavigator bnav)
        {
            bs = new BindingSource(); 
            tables = new BindingList<DataTable>();
            DataTable dt = null;
            int counter = 1;
            TotalRecords = dataTable.Rows.Count;            
            TotalPages = (int)Math.Ceiling((double)TotalRecords/ PageSize);

            foreach (DataRow dr in dataTable.Rows)
            {
                if (counter == 1)
                {
                    dt = dataTable.Clone();
                    tables.Add(dt);
                }
                dt.Rows.Add(dr.ItemArray);
                if (PageSize < ++counter)
                {
                    counter = 1;
                } 
            }
            bnav.BindingSource = bs;
            bs.DataSource = tables;
            bs.PositionChanged += bs_PositionChanged;
            bs_PositionChanged(bs, EventArgs.Empty);
            
        }
        void bs_PositionChanged(object sender, EventArgs e)
        {
           // if (bs.Position > 0)
                this.DataSource = tables[bs.Position];
             PageNo = bs.Position +1;
        }

        //public void SetPagedDataSource1(Task<JsonResponse> jsonResp, BindingNavigator bnav)
        //{
        //    bs = new BindingSource();
        //    tables = new BindingList<DataTable>();
        //    PageSize = Convert.ToInt32(jsonResp.pagination.limit);
        //    DataTable dt = null;
        //    int counter = 1;
        //    foreach (JsonResponse.empdata emp in jsonResp.data.ToList())
        //    {
        //        if (counter == 1)
        //        {
        //            dt = new DataTable();
        //            tables.Add(dt);
        //        }
        //        dt.Rows.Add(emp);

        //        if (PageSize < ++counter)
        //        {
        //            counter = 1;
        //        }
        //    }
        //    bnav.BindingSource = bs;
        //    bs.DataSource = tables;
        //    bs.PositionChanged += bs_PositionChanged;
        //    bs_PositionChanged(bs, EventArgs.Empty);

        //}
    }
}

