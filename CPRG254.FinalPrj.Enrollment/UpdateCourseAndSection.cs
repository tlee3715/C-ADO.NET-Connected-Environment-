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
    public partial class UpdateCourseAndSection : Form
    {
        IRepository<ICourse> CourseRepository = RepositoryFactory.CourseRepository;
        IRepository<ICourseSection> SectionRepository = RepositoryFactory.CourseSectionRepository;
        IRepository<IDepartment> DepartmentRepository = RepositoryFactory.DepartmentRepository;
        ICourse course;
        ICourseSection section;

        public UpdateCourseAndSection()
        {
            InitializeComponent();
        }

        private void UpdateCourseAndSection_Load(object sender, EventArgs e)
        {
            PopulateCourseList();
            PopulateCourseComboBox();
            PopulateSectionList();
            PopulateDepartmentComboBox();
            MessageBox.Show("Select Course & Section On the Grid View to load data to text boxes for easier modification", 
                            "Suggestion !", 
                             MessageBoxButtons.OK, 
                             MessageBoxIcon.Information);
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

        private void PopulateSectionList()
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

        private void PopulateCourseList()
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
                course.Id = Convert.ToInt32(uxCourseId.Text);
                course.Code = uxCode.Text;
                course.Name = uxCourseName.Text;
                course.Description = uxDescription.Text;
                course.Fee = Convert.ToDecimal(uxFee.Text);
                course.DepartmentId = Convert.ToInt32(uxDepartments.SelectedValue);
                string confirmation = $"Update Info for {course.Name} (Code: {course.Code}) ??";
                var dialog =
                    MessageBox.Show(confirmation, "Update Course Info Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (CourseRepository.Update(course) == 1)
                    {
                        MessageBox.Show("Course Info Updated Successfully");
                        PopulateCourseList();
                        PopulateCourseComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ! Please check your input data");
                    }
                }
                else return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ! Please Check Your Input or Contact Database Administrator For Information !", 
                                "Error", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Error);
            }
        }

        private void uxSectionOk_Click(object sender, EventArgs e)
        {
            try
            {
                section = new CourseSection();
                section.Id = Convert.ToInt32(uxSectionId.Text);
                section.CourseId = Convert.ToInt32(uxCourses.SelectedValue);
                section.SectionCode = uxSectionCode.Text;
                section.StartDate = uxStartDate.Value.Date;
                section.EndDate = uxEndDate.Value.Date;
                section.RoomNumber = uxRoomNumber.Text;
                string confirmation = $"Update Info for section for course {uxCourses.Text} (code {section.SectionCode}) Start Date {section.StartDate.Date.ToShortDateString()} ??";
                var dialog =
                    MessageBox.Show(confirmation, 
                                    "Update Course Section Confirmation", 
                                    MessageBoxButtons.OKCancel, 
                                    MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (SectionRepository.Update(section) == 1)
                    {
                        MessageBox.Show("Section Info Updated Successfully");
                        PopulateSectionList();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ! Please check your input data");
                    }
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! Please Check Your Input (Section Code cannot exceed 1 (one) character in length) or Contact Database Administrator For Information", 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void uxCoursesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var RowIndex = e.RowIndex;
                DataGridViewRow selectedRow = uxCoursesGrid.Rows[RowIndex];
                uxCourseId.Text = selectedRow.Cells[0].Value.ToString();
                uxCode.Text = selectedRow.Cells[1].Value.ToString();
                uxCourseName.Text = selectedRow.Cells[2].Value.ToString();
                uxDescription.Text = selectedRow.Cells[3].Value.ToString();
                uxFee.Text = selectedRow.Cells[4].Value.ToString();
                uxDepartments.SelectedValue = selectedRow.Cells[5].Value;
            }
            catch
            {
                return;
            }        
        }

        private void uxSectionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var RowIndex = e.RowIndex;
                DataGridViewRow selectedRow = uxSectionGrid.Rows[RowIndex];
                uxSectionId.Text = selectedRow.Cells[0].Value.ToString();
                uxCourses.SelectedValue = selectedRow.Cells[1].Value;
                uxSectionCode.Text = selectedRow.Cells[2].Value.ToString();
                uxStartDate.Value = (DateTime)selectedRow.Cells[3].Value;
                uxEndDate.Value = (DateTime)selectedRow.Cells[4].Value;
                uxRoomNumber.Text = selectedRow.Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }          
        }      
    }
}
