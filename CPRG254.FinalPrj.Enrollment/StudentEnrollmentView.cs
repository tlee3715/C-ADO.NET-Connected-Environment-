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
    public partial class StudentEnrollmentView : Form
    {
        bool IsLoaded = false;
        IRepository<IStudent> StudentRepository = StudentManager.StudentInstance;
        IRepository<ICourse> CourseRepository = CourseManager.CourseInstance;
        IRepository<ICourseSection> SectionRepository = CourseSectionManager.CourseSectionInstance;
        IRepository<IClassRoster> RosterRepository = ClassRosterManager.RosterInstance;

        public StudentEnrollmentView()
        {
            InitializeComponent();
        }

        private void StudentEnrollmentView_Load(object sender, EventArgs e)
        {
            LoadStudentList();
            LoadEnrollmentView();
        }

        private void LoadStudentList()
        {
            uxStudents.DataSource = StudentRepository.Items.Cast<Student>().ToList();
            uxStudents.DisplayMember = "DisplayFullName";
            uxStudents.ValueMember = "Id";
            uxStudents.SelectedIndex = 1;
            IsLoaded = true;
        }

        private void uxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEnrollmentView();
        }

        private void LoadEnrollmentView()
        {
            uxFee.Text = "";
            try
            {
                if (IsLoaded == true)
                {
                    var result = from c in CourseRepository.Items
                                 join s in SectionRepository.Items on c.Id equals s.CourseId
                                 join r in RosterRepository.Items on s.Id equals r.CourseSectionId
                                 join st in StudentRepository.Items on r.StudentId equals st.Id
                                 where st.Id == (int)uxStudents.SelectedValue
                                 orderby c.Name
                                 select new
                                 {
                                     Code = c.Code,
                                     Name = c.Name,
                                     Fee = c.Fee.ToString("c")
                                 };

                    var fee = from c in CourseRepository.Items
                              join s in SectionRepository.Items on c.Id equals s.CourseId
                              join r in RosterRepository.Items on s.Id equals r.CourseSectionId
                              join st in StudentRepository.Items on r.StudentId equals st.Id
                              where st.Id == (int)uxStudents.SelectedValue
                              group c by st.Id into z
                              select new { Sum = z.Sum(o => o.Fee) };

                    uxDisplay.DataSource = result.ToList();

                    foreach (var group in fee)
                    {
                        uxFee.Text = group.Sum.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Retrieving Data", ex.Message);
            }
        }
    }
}
