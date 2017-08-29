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
    public partial class MainForm : Form
    {
        #region Form Objects
        StudentEnrollmentView stdformview;
        CourseAndSectionView courseview;
        ClassListView classview;
        AddStudent stdadd;
        AddCourseAndSection courseadd;
        UpdateStudent stdupdate;
        UpdateCourseAndSection courseupdate;
        ClassRosterSetUp roster;
        #endregion

        #region MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Windows Forms Organizer
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        #region "Exit" Tool Strip Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Student Enrollment View Form
        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stdformview == null || stdformview.IsDisposed == true)
            {
                stdformview = new StudentEnrollmentView();
                stdformview.MdiParent = this;
            }
            stdformview.Show();
            stdformview.BringToFront();
        }
        #endregion

        #region Course and Department Form
        private void courseDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (courseview == null || courseview.IsDisposed == true)
            {
                courseview = new CourseAndSectionView();
                courseview.MdiParent = this;
            }
            courseview.Show();
            courseview.BringToFront();
        }
        #endregion

        #region Class List View
        private void classListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classview == null || classview.IsDisposed == true)
            {
                classview = new ClassListView();
                classview.MdiParent = this;
            }
            classview.Show();
            classview.BringToFront();
        }
        #endregion

        #region Add Course and Section Form
        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (courseadd == null || courseadd.IsDisposed == true)
            {
                courseadd = new AddCourseAndSection();
                courseadd.MdiParent = this;
            }
            courseadd.Show();
            courseadd.BringToFront();
        }
        #endregion

        #region Update Student Data Form
        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (stdupdate == null || stdupdate.IsDisposed == true)
            {
                stdupdate = new UpdateStudent();
                stdupdate.MdiParent = this;
            }
            stdupdate.Show();
            stdupdate.BringToFront();
        }
        #endregion

        #region Update Course and Section Data Form
        private void courseAndSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (courseupdate == null || courseupdate.IsDisposed == true)
            {
                courseupdate = new UpdateCourseAndSection();
                courseupdate.MdiParent = this;
            }
            courseupdate.Show();
            courseupdate.BringToFront();
        }
        #endregion

        #region Class Roster Setup Form
        private void classRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roster == null || roster.IsDisposed == true)
            {
                roster = new ClassRosterSetUp();
                roster.MdiParent = this;
            }
            roster.Show();
            roster.BringToFront();
        }
        #endregion

        #region Add New Student Form
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stdadd == null || stdadd.IsDisposed == true)
            {
                stdadd = new AddStudent();
                stdadd.MdiParent = this;
            }
            stdadd.Show();
            stdadd.BringToFront();
        }
        #endregion

        #region Form Closing Event Confirmation Dialog
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result =
                MessageBox.Show("Are sure you want to exit the application ?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region FormLoad
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
