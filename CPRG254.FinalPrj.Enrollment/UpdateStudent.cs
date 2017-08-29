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
    public partial class UpdateStudent : Form
    {
        bool _Isloaded = true;
        IRepository<IStudent> StudentRepository = RepositoryFactory.StudentRepository;
        IRepository<IProvince> ProvinceRepository = RepositoryFactory.ProvinceRepository;
        IRepository<IDepartment> DeptRepository = RepositoryFactory.DepartmentRepository;
        IStudent std = null;

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            PopulateProvince();
            PopulateDepartment();
            PopulateStudentData();
            MessageBox.Show("Select a Student On the Grid View to load data to text boxes for easier modification", "Suggestion !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void PopulateStudentData()
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

        private void uxStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_Isloaded)
                {
                    int RowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = uxStudents.Rows[RowIndex];
                    //.Cell[] can be an index-based integer or column name
                    uxID.Text = selectedRow.Cells[0].Value.ToString();
                    uxFirstName.Text = selectedRow.Cells[1].Value.ToString();
                    uxLastName.Text = selectedRow.Cells[2].Value.ToString();
                    uxAddress.Text = selectedRow.Cells[3].Value.ToString();
                    uxCity.Text = selectedRow.Cells[4].Value.ToString();
                    uxProvince.SelectedValue = selectedRow.Cells[5].Value;
                    uxPostalCode.Text = selectedRow.Cells[6].Value.ToString();
                    uxPhone.Text = selectedRow.Cells[7].Value.ToString();
                    uxEmail.Text = selectedRow.Cells[8].Value.ToString();
                    uxDepartment.SelectedValue = selectedRow.Cells[9].Value;
                }
            }
            catch
            {
                MessageBox.Show("Please select a cell on grid view to load data !", 
                                "Info !", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }         
        }

        private void uxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _Isloaded = false;
                std = new Student();
                std.Id = Convert.ToInt32(uxID.Text);
                std.FirstName = uxFirstName.Text;
                std.LastName = uxLastName.Text;
                std.Address = uxAddress.Text;
                std.City = uxCity.Text;
                std.ProvinceId = Convert.ToInt32(uxProvince.SelectedValue);
                std.PostalCode = uxPostalCode.Text;
                std.Phone = uxPhone.Text;
                std.Email = uxEmail.Text;
                std.DepartmentId = Convert.ToInt32(uxDepartment.SelectedValue);
                _Isloaded = true;
                string confirmation = $"Update Info for Student {std.FirstName} {std.LastName} (ID {std.Id}) ??";
                var dialog = 
                   MessageBox.Show(confirmation, "Update Student Info Confirmation !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (StudentRepository.Update(std) == 1)
                    {
                        MessageBox.Show("Student Info Updated Successfully");
                    }
                    else MessageBox.Show("Invalid ! Please check your input data");
                }
            }
            catch
            {
                MessageBox.Show("Error ! Please Check Your Input or Contact Database Administrator For Information !",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            PopulateStudentData();
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

        private void UpdateStudent_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void uxStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uxStudents_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
