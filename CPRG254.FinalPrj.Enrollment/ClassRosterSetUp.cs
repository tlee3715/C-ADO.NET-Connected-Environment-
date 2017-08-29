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
    public partial class ClassRosterSetUp : Form
    {
        IRepository<ICourse> CourseRepository = RepositoryFactory.CourseRepository;
        IRepository<IStudent> StudentRepository = RepositoryFactory.StudentRepository;
        IRepository<ICourseSection> CourseSectionRepository = RepositoryFactory.CourseSectionRepository;
        IRepository<IClassRoster> RosterRepository = RepositoryFactory.RosterRepository;
        IClassRoster roster;

        public ClassRosterSetUp()
        {
            InitializeComponent();
        }

        private void ClassRosterSetUp_Load(object sender, EventArgs e)
        {
            CourseDataInfo();
            StudentDataInfo();
            ClassRosterView();
        }

        private void ClassRosterView()
        {
            uxRoster.DataSource = RosterRepository.Items;
            uxRoster.Columns.Remove("CourseSectionId");

            var SectionColumn = new DataGridViewComboBoxColumn();
            SectionColumn.DataPropertyName = "CourseSectionId";
            SectionColumn.HeaderText = "Section Code";
            SectionColumn.Width = 100;
            SectionColumn.FlatStyle = FlatStyle.Standard;
            SectionColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            SectionColumn.DisplayStyleForCurrentCellOnly = true;
            SectionColumn.DataSource = CourseSectionRepository.Items;
            SectionColumn.DisplayMember = "SectionCode";
            SectionColumn.ValueMember = "Id";

            uxRoster.Columns.Add(SectionColumn);
        }

        private void StudentDataInfo()
        {
            uxStudents.DataSource = StudentRepository.Items.Cast<Student>().ToList();
            uxStudents.DisplayMember = "DisplayFullName";
            uxStudents.ValueMember = "Id";
        }

        private void CourseDataInfo()
        {
            uxCourses.DataSource = CourseRepository.Items.Cast<Course>().ToList();
            uxCourses.DisplayMember = "Display";
            uxCourses.ValueMember = "Id";
        }

        private void uxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var course = (ICourse)uxCourses.SelectedItem;
            uxCourseSections.DataSource = null;
            var section = CourseSectionRepository.Items.Where(o => o.CourseId == course.Id).Cast<CourseSection>().ToList();      
            uxCourseSections.DisplayMember = "Info";
            uxCourseSections.ValueMember = "Id";
            uxCourseSections.DataSource = section;
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                roster = new ClassRoster();
                roster.CourseSectionId = Convert.ToInt32(uxCourseSections.SelectedValue);
                roster.StudentId = Convert.ToInt32(uxStudents.SelectedValue);
                roster.DateRegistered = DateTime.Now.Date;
                if (RosterRepository.Add(roster) == 1)
                {
                    MessageBox.Show("Successfully added student to course !");
                    ClassRosterView();
                }
                else MessageBox.Show("Invalid !");
            }
            catch
            {
                return;
                //MessageBox.Show("Error ! Please Check Your Input or Contact Database Administrator For Information !",
                //                "Error",MessageBoxButtons.OK,
                //                MessageBoxIcon.Error);
            }
        }
    }
}
