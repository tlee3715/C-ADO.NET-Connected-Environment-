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
    public partial class CourseAndSectionView : Form
    {
        bool IsLoaded = false;
        IRepository<IDepartment> DepartmentRepository = DepartmentManager.DepartmentInstance;
        IRepository<ICourse> CourseRepository = CourseManager.CourseInstance;
        IRepository<ICourseSection> SectionRepository = CourseSectionManager.CourseSectionInstance;

        public CourseAndSectionView()
        {
            InitializeComponent();
        }

        private void CourseAndSectionView_Load(object sender, EventArgs e)
        {
            LoadDepartmentList();
            LoadCourseInfo();
        }

        private void LoadDepartmentList()
        {
            uxDepartments.DataSource = DepartmentRepository.Items;
            uxDepartments.DisplayMember = "Name";
            uxDepartments.ValueMember = "Id";
            IsLoaded = true;
        }

        private void uxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourseInfo();
        }

        private void LoadCourseInfo()
        {
            try
            {
                if (IsLoaded == true)
                {
                    var result = from c in CourseRepository.Items
                                 join s in SectionRepository.Items on c.Id equals s.CourseId
                                 join d in DepartmentRepository.Items on c.DepartmentId equals d.Id
                                 where d.Id == (int)uxDepartments.SelectedValue
                                 select new
                                 {
                                     c.Code,
                                     c.Name,
                                     s.SectionCode,
                                     StartDate = s.StartDate.Date,
                                     EndDate = s.EndDate.Date
                                 };

                    uxDisplay.DataSource = result.ToList();
                }
            }
            catch
            {
                return;
            };
        }
    }
}
