
namespace EmployeeManagementSystem
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnEmpClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.cboEmpStatus = new System.Windows.Forms.ComboBox();
            this.cboEmpGender = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblConj = new System.Windows.Forms.Label();
            this.txtTotalRec = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblcurrPage = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Location = new System.Drawing.Point(70, 38);
            this.btnListAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(140, 46);
            this.btnListAll.TabIndex = 12;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.Location = new System.Drawing.Point(298, 38);
            this.btnEmpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(140, 46);
            this.btnEmpAdd.TabIndex = 14;
            this.btnEmpAdd.Text = "Add";
            this.btnEmpAdd.UseVisualStyleBackColor = true;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpUpdate.Location = new System.Drawing.Point(530, 38);
            this.btnEmpUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(140, 46);
            this.btnEmpUpdate.TabIndex = 15;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDelete.Location = new System.Drawing.Point(762, 38);
            this.btnEmpDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(140, 46);
            this.btnEmpDelete.TabIndex = 16;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDSearch.Location = new System.Drawing.Point(618, 75);
            this.btnIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(140, 46);
            this.btnIDSearch.TabIndex = 13;
            this.btnIDSearch.Text = "Search";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(212, 81);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpID.MaxLength = 5;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(386, 31);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(212, 212);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpName.MaxLength = 50;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(386, 31);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(212, 340);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpEmail.MaxLength = 50;
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(386, 31);
            this.txtEmpEmail.TabIndex = 7;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnEmpClear);
            this.pnlButtons.Controls.Add(this.btnEmpDelete);
            this.pnlButtons.Controls.Add(this.btnListAll);
            this.pnlButtons.Controls.Add(this.btnEmpAdd);
            this.pnlButtons.Controls.Add(this.btnEmpUpdate);
            this.pnlButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons.Location = new System.Drawing.Point(668, 1179);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(6);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1270, 113);
            this.pnlButtons.TabIndex = 10;
            // 
            // btnEmpClear
            // 
            this.btnEmpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpClear.Location = new System.Drawing.Point(994, 38);
            this.btnEmpClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpClear.Name = "btnEmpClear";
            this.btnEmpClear.Size = new System.Drawing.Size(140, 46);
            this.btnEmpClear.TabIndex = 17;
            this.btnEmpClear.Text = "Clear";
            this.btnEmpClear.UseVisualStyleBackColor = true;
            this.btnEmpClear.Click += new System.EventHandler(this.btnEmpClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNameSearch);
            this.panel1.Controls.Add(this.cboEmpStatus);
            this.panel1.Controls.Add(this.cboEmpGender);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.btnIDSearch);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblEmployeeID);
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.txtEmpEmail);
            this.panel1.Location = new System.Drawing.Point(50, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 808);
            this.panel1.TabIndex = 4;
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameSearch.Location = new System.Drawing.Point(618, 212);
            this.btnNameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(140, 46);
            this.btnNameSearch.TabIndex = 14;
            this.btnNameSearch.Text = "Search";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // cboEmpStatus
            // 
            this.cboEmpStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cboEmpStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmpStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboEmpStatus.FormattingEnabled = true;
            this.cboEmpStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboEmpStatus.Location = new System.Drawing.Point(212, 594);
            this.cboEmpStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cboEmpStatus.Name = "cboEmpStatus";
            this.cboEmpStatus.Size = new System.Drawing.Size(386, 33);
            this.cboEmpStatus.TabIndex = 11;
            // 
            // cboEmpGender
            // 
            this.cboEmpGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.cboEmpGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmpGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboEmpGender.FormattingEnabled = true;
            this.cboEmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboEmpGender.Location = new System.Drawing.Point(212, 460);
            this.cboEmpGender.Margin = new System.Windows.Forms.Padding(6);
            this.cboEmpGender.Name = "cboEmpGender";
            this.cboEmpGender.Size = new System.Drawing.Size(386, 33);
            this.cboEmpGender.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(26, 594);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 30);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(26, 462);
            this.lblGender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 30);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(26, 340);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 30);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 212);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 30);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(26, 87);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(152, 30);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "EmployeeID";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.CausesValidation = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(24, 131);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployee.Size = new System.Drawing.Size(1284, 862);
            this.dgvEmployee.TabIndex = 18;
            this.dgvEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_RowHeaderMouseClick);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.lblcurrPage);
            this.pnlGrid.Controls.Add(this.lblPages);
            this.pnlGrid.Controls.Add(this.lblConj);
            this.pnlGrid.Controls.Add(this.txtTotalRec);
            this.pnlGrid.Controls.Add(this.btnGo);
            this.pnlGrid.Controls.Add(this.txtPageNo);
            this.pnlGrid.Controls.Add(this.btnNext);
            this.pnlGrid.Controls.Add(this.btnPrevious);
            this.pnlGrid.Controls.Add(this.dgvEmployee);
            this.pnlGrid.Location = new System.Drawing.Point(960, 54);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(6);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1330, 1015);
            this.pnlGrid.TabIndex = 20;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(621, 63);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(24, 25);
            this.lblPages.TabIndex = 26;
            this.lblPages.Text = "0";
            // 
            // lblConj
            // 
            this.lblConj.AutoSize = true;
            this.lblConj.Location = new System.Drawing.Point(585, 63);
            this.lblConj.Name = "lblConj";
            this.lblConj.Size = new System.Drawing.Size(30, 25);
            this.lblConj.TabIndex = 25;
            this.lblConj.Text = "of";
            // 
            // txtTotalRec
            // 
            this.txtTotalRec.Enabled = false;
            this.txtTotalRec.Location = new System.Drawing.Point(970, 60);
            this.txtTotalRec.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalRec.Name = "txtTotalRec";
            this.txtTotalRec.Size = new System.Drawing.Size(136, 31);
            this.txtTotalRec.TabIndex = 23;
            this.txtTotalRec.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(669, 56);
            this.btnGo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(62, 44);
            this.btnGo.TabIndex = 22;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(440, 60);
            this.txtPageNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtPageNo.MaxLength = 4;
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(136, 31);
            this.txtPageNo.TabIndex = 21;
            this.txtPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNo_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(754, 56);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 44);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(268, 54);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(150, 44);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<<Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblcurrPage
            // 
            this.lblcurrPage.AutoSize = true;
            this.lblcurrPage.Location = new System.Drawing.Point(1152, 64);
            this.lblcurrPage.Name = "lblcurrPage";
            this.lblcurrPage.Size = new System.Drawing.Size(24, 25);
            this.lblcurrPage.TabIndex = 27;
            this.lblcurrPage.Text = "0";
            this.lblcurrPage.Visible = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2526, 1315);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployee";
            this.Text = "Employee Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cboEmpStatus;
        private System.Windows.Forms.ComboBox cboEmpGender;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnEmpClear;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTotalRec;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblConj;
        private System.Windows.Forms.Label lblcurrPage;
    }
}

