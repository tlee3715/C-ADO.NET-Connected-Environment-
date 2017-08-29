namespace CPRG254.FinalPrj.Enrollment
{
    partial class ClassRosterSetUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxCourses = new System.Windows.Forms.ComboBox();
            this.uxCourseSections = new System.Windows.Forms.ComboBox();
            this.uxStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uxRoster = new System.Windows.Forms.DataGridView();
            this.uxAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uxRoster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxCourses
            // 
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.Location = new System.Drawing.Point(107, 64);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(262, 21);
            this.uxCourses.TabIndex = 0;
            this.toolTip1.SetToolTip(this.uxCourses, "Select a course");
            this.uxCourses.SelectedIndexChanged += new System.EventHandler(this.uxCourses_SelectedIndexChanged);
            // 
            // uxCourseSections
            // 
            this.uxCourseSections.FormattingEnabled = true;
            this.uxCourseSections.Location = new System.Drawing.Point(107, 108);
            this.uxCourseSections.Name = "uxCourseSections";
            this.uxCourseSections.Size = new System.Drawing.Size(336, 21);
            this.uxCourseSections.TabIndex = 1;
            this.toolTip1.SetToolTip(this.uxCourseSections, "Select course section");
            // 
            // uxStudents
            // 
            this.uxStudents.FormattingEnabled = true;
            this.uxStudents.Location = new System.Drawing.Point(107, 155);
            this.uxStudents.Name = "uxStudents";
            this.uxStudents.Size = new System.Drawing.Size(262, 21);
            this.uxStudents.TabIndex = 2;
            this.toolTip1.SetToolTip(this.uxStudents, "Select a student");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Section:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(146, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 27);
            this.label11.TabIndex = 44;
            this.label11.Text = "CLASS ROSTER";
            // 
            // uxRoster
            // 
            this.uxRoster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uxRoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxRoster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxRoster.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxRoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxRoster.EnableHeadersVisualStyles = false;
            this.uxRoster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uxRoster.Location = new System.Drawing.Point(0, 249);
            this.uxRoster.Name = "uxRoster";
            this.uxRoster.Size = new System.Drawing.Size(483, 157);
            this.uxRoster.TabIndex = 45;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(195, 205);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(84, 23);
            this.uxAdd.TabIndex = 46;
            this.uxAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.uxAdd, "Add student to existing class");
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 246);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(483, 3);
            this.splitter1.TabIndex = 47;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uxAdd);
            this.panel1.Controls.Add(this.uxCourses);
            this.panel1.Controls.Add(this.uxCourseSections);
            this.panel1.Controls.Add(this.uxStudents);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 255);
            this.panel1.TabIndex = 48;
            // 
            // ClassRosterSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.uxRoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClassRosterSetUp";
            this.Text = "Class Roster Set Up";
            this.Load += new System.EventHandler(this.ClassRosterSetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxRoster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uxCourses;
        private System.Windows.Forms.ComboBox uxCourseSections;
        private System.Windows.Forms.ComboBox uxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView uxRoster;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
    }
}