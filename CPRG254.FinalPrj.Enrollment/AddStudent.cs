using CPRG254.SchoolData.Domain;
using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG254.FinalPrj.Enrollment
{
    public partial class AddStudent : Form
    {
        bool _Isloaded = true;
        IRepository<IStudent> StudentRepository = RepositoryFactory.StudentRepository;
        IRepository<IProvince> ProvinceRepository = RepositoryFactory.ProvinceRepository;
        IRepository<IDepartment> DeptRepository = RepositoryFactory.DepartmentRepository;
        IStudent std = null;

        public AddStudent()
        {
            InitializeComponent();          
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            PopulateProvince();
            PopulateDepartment();
        }

        private void PopulateDepartment()
        {
            uxDepartment.DataSource = DeptRepository.Items;
            uxDepartment.DisplayMember = "Name";
            uxDepartment.ValueMember = "Id";
        }

        private void PopulateProvince()
        {
            uxProvince.DataSource = ProvinceRepository.Items;
            uxProvince.DisplayMember = "Name";
            uxProvince.ValueMember = "Id";        
        }

        #region Refresh Data Grid View
        private void PopulateDataGridView()
        {
            try
            {
                uxStudents.DataSource = StudentRepository.Items;
                uxStudents.Columns.Remove("DepartmentId");
                uxStudents.Columns.Remove("ProvinceId");

                var ProvinceColumn = new DataGridViewComboBoxColumn();
                ProvinceColumn.DataPropertyName = "ProvinceId";
                ProvinceColumn.HeaderText = "Province";
                ProvinceColumn.Width = 100;
                ProvinceColumn.FlatStyle = FlatStyle.Standard;
                ProvinceColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                ProvinceColumn.DisplayStyleForCurrentCellOnly = true;
                ProvinceColumn.DataSource = ProvinceRepository.Items;
                ProvinceColumn.DisplayMember = "Name";
                ProvinceColumn.ValueMember = "Id";

                uxStudents.Columns.Add(ProvinceColumn);
                uxStudents.Columns[8].DisplayIndex = 4;

                var DepartmentColumn = new DataGridViewComboBoxColumn();
                DepartmentColumn.DataPropertyName = "DepartmentId";
                DepartmentColumn.HeaderText = "Department";
                DepartmentColumn.Width = 150;
                DepartmentColumn.FlatStyle = FlatStyle.Standard;
                DepartmentColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                DepartmentColumn.DisplayStyleForCurrentCellOnly = true;
                DepartmentColumn.DataSource = DeptRepository.Items;
                DepartmentColumn.DisplayMember = "Name";
                DepartmentColumn.ValueMember = "Id";

                uxStudents.Columns.Add(DepartmentColumn);
                uxStudents.Columns[9].DisplayIndex = 3;
            }
            catch
            {
                return;
            }        
        }
        #endregion

        private void uxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                std = new Student();
                std.FirstName = uxFirstName.Text;
                std.LastName = uxLastName.Text;
                std.Address = uxAddress.Text;
                std.City = uxCity.Text;
                std.ProvinceId = Convert.ToInt32(uxProvince.SelectedValue);
                std.PostalCode = uxPostalCode.Text;
                std.Phone = uxPhone.Text;
                std.Email = uxEmail.Text;
                std.DepartmentId = Convert.ToInt32(uxDepartment.SelectedValue);
                if (StudentRepository.Add(std) == 1)
                {
                    MessageBox.Show("New Student Info Added Successfully");                            
                }
                else MessageBox.Show("Missing Student Info ! Please fix");
            }
            catch(Exception ex)
            {
                throw new Exception("Error transfering data to databse !", ex);
            }
            PopulateDataGridView();
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            uxFirstName.Text = "";
            uxLastName.Text = "";
            uxAddress.Text = "";
            uxCity.Text = "";
            uxPostalCode.Text = "";
            uxPhone.Text = "";
            uxEmail.Text = "";
        }
    }
}
