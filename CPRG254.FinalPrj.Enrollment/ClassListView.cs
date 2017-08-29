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
    public partial class ClassListView : Form
    {
        bool IsLoaded = false;
        IRepository<IClassRoster> RosterRepository = RepositoryFactory.RosterRepository;
        IRepository<IStudent> StudentRepository = StudentManager.StudentInstance;
        IRepository<ICourse> CourseRepository = RepositoryFactory.CourseRepository;
        IRepository<ICourseSection> SectionRepository = RepositoryFactory.CourseSectionRepository;
        IRepository<IDepartment> DepartmentRepository = RepositoryFactory.DepartmentRepository;

        public ClassListView()
        {
            InitializeComponent();
        }

        private void ClassListView_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadClassList();
        }

        private void LoadCourses()
        {
            uxCourses.DataSource = CourseRepository.Items.Cast<Course>().ToList();
            uxCourses.DisplayMember = "Display";
            uxCourses.ValueMember = "Id";
            IsLoaded = true;
        }

        private void uxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var course = (ICourse)uxCourses.SelectedItem;
            uxSection.DataSource = null;
            var section = SectionRepository.Items.Where(o => o.CourseId == course.Id).Cast<CourseSection>().ToList();
            uxSection.DisplayMember = "Info";
            uxSection.ValueMember = "Id";
            uxSection.DataSource = section;
        }

        private void uxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassList();
        }

        private void LoadClassList()
        {
            try
            {
                if(IsLoaded == true)
                {
                    var result = from d in DepartmentRepository.Items
                                 join st in StudentRepository.Items on d.Id equals st.DepartmentId
                                 join r in RosterRepository.Items on st.Id equals r.StudentId
                                 join s in SectionRepository.Items on r.CourseSectionId equals s.Id
                                 join c in CourseRepository.Items on s.CourseId equals c.Id
                                 where c.Id == (int)uxCourses.SelectedValue && s.Id == (int)uxSection.SelectedValue
                                 select new
                                 {
                                     StudentID = st.Id,
                                     st.FirstName,
                                     st.LastName,
                                     DepartmentCode = d.Code,
                                     DateRegistered = r.DateRegistered.Date
                                 };

                    uxDisplay.DataSource = result.ToList();
                }            
            }
            catch
            {
                return;
            }
        }
    }
}
