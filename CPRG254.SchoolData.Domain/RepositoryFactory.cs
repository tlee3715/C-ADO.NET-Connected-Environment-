using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Domain
{
    public class RepositoryFactory
    {
        #region Student Repository
        public static IRepository<IStudent> StudentRepository
        {
            get
            {
                return StudentManager.StudentInstance;
            }
        }
        #endregion

        #region Province Repository
        public static IRepository<IProvince> ProvinceRepository
        {
            get
            {
                return ProvinceManager.ProvinceInstance;
            }
        }
        #endregion

        #region Department Repository
        public static IRepository<IDepartment> DepartmentRepository
        {
            get
            {
                return DepartmentManager.DepartmentInstance;
            }
        }
        #endregion

        #region Course Repository
        public static IRepository<ICourse> CourseRepository
        {
            get
            {
                return CourseManager.CourseInstance;
            }
        }
        #endregion

        #region Course Section Repository
        public static IRepository<ICourseSection> CourseSectionRepository
        {
            get
            {
                return CourseSectionManager.CourseSectionInstance;
            }
        }
        #endregion

        #region Roster Repository
        public static IRepository<IClassRoster> RosterRepository
        {
            get
            {
                return ClassRosterManager.RosterInstance;
            }
        }
        #endregion
      
    }
}
