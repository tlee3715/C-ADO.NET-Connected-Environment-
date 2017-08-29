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
    public partial class AddCourseAndSection : Form
    {
        IRepository<ICourse> CourseRepository = RepositoryFactory.CourseRepository;
        IRepository<ICourseSection> SectionRepository = RepositoryFactory.CourseSectionRepository;
        IRepository<IDepartment> DepartmentRepository = RepositoryFactory.DepartmentRepository;
        ICourse course;
        ICourseSection section;

        public AddCourseAndSection()
        {
            InitializeComponent();
        }

        private void AddCourseAndSection_Load(object sender, EventArgs e)
        {
            PopulateCourseGrid();
            PopulateCourseComboBox();
            PopulateSectionGrid();
            PopulateDepartmentComboBox();
        }

        private void PopulateDepartmentComboBox()
        {
            uxDepartments.DataSource = DepartmentRepository.Items;
            uxDepartments.DisplayMember = "Name";
            uxDepartments.ValueMember = "Id";
        }

        private void PopulateCourseComboBox()
        {
            uxCourses.DataSource = CourseRepository.Items.Cast<Course>().ToList();
            uxCourses.DisplayMember = "Display";
            uxCourses.ValueMember = "Id";
        }

        private void PopulateSectionGrid()
        {
            try
            {
                uxSectionGrid.DataSource = SectionRepository.Items;
                uxSectionGrid.Columns.Remove("CourseId");

                var CourseColumn = new DataGridViewComboBoxColumn();
                CourseColumn.DataPropertyName = "CourseId";
                CourseColumn.HeaderText = "Course Name";
                CourseColumn.Width = 100;
                CourseColumn.FlatStyle = FlatStyle.Standard;
                CourseColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                CourseColumn.DisplayStyleForCurrentCellOnly = true;
                CourseColumn.DataSource = CourseRepository.Items;
                CourseColumn.DisplayMember = "Name";
                CourseColumn.ValueMember = "Id";

                uxSectionGrid.Columns.Add(CourseColumn);
            }
            catch
            {
                return;
            }
        }

        private void PopulateCourseGrid()
        {
            try
            {
                uxCoursesGrid.DataSource = CourseRepository.Items;
                uxCoursesGrid.Columns.Remove("DepartmentId");

                var DeptColumn = new DataGridViewComboBoxColumn();
                DeptColumn.DataPropertyName = "DepartmentId";
                DeptColumn.HeaderText = "Department";
                DeptColumn.Width = 100;
                DeptColumn.FlatStyle = FlatStyle.Standard;
                DeptColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                DeptColumn.DisplayStyleForCurrentCellOnly = true;
                DeptColumn.DataSource = DepartmentRepository.Items;
                DeptColumn.DisplayMember = "Name";
                DeptColumn.ValueMember = "Id";

                uxCoursesGrid.Columns.Add(DeptColumn);
            }
            catch
            {
                return;
            }
        }

        private void uxCourseOk_Click(object sender, EventArgs e)
        {
            try
            {
                course = new Course();
                course.Code = uxCode.Text;
                course.Name = uxCourseName.Text;
                course.Description = uxCourseName.Text;
                course.Fee = Convert.ToDecimal(uxFee.Text);
                course.DepartmentId = Convert.ToInt32(uxDepartments.SelectedValue);
                if (CourseRepository.Add(course) == 1)
                {
                    MessageBox.Show("New Course Added Successfully !", "Course Added");
               
                }
                else MessageBox.Show("Invalid ! Please check your input data", "Failed");
            }
            catch
            {
                MessageBox.Show("Error ! Please Check Your Input or Contact Database Administrator For Information !",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            PopulateCourseGrid();
            PopulateCourseComboBox();
        }

        private void uxSectionOk_Click(object sender, EventArgs e)
        {
            try
            {
                section = new CourseSection();
                section.CourseId = Convert.ToInt32(uxCourses.SelectedValue);
                section.SectionCode = uxSectionCode.Text;
                section.StartDate = uxStartDate.Value.Date;
                section.EndDate = uxEndDate.Value.Date;
                section.RoomNumber = uxRoomNumber.Text;
                if (SectionRepository.Add(section) == 1)
                {
                    MessageBox.Show("Successfully Added Section to The Selected Course", "Section Added");
                }
                else MessageBox.Show("Invalid ! Please check your input data", "Failed");
            }
            catch
            {
                MessageBox.Show("Error ! Please Check Your Input (Section Code cannot exceed 1 (one) character in length) or Contact Database Administrator For Information",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            PopulateSectionGrid();
        }
    }
}
