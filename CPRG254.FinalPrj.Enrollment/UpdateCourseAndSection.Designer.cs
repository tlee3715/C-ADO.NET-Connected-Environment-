namespace CPRG254.FinalPrj.Enrollment
{
    partial class UpdateCourseAndSection
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uxEndDate = new System.Windows.Forms.DateTimePicker();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.uxRoomNumber = new System.Windows.Forms.TextBox();
            this.uxCourses = new System.Windows.Forms.ComboBox();
            this.uxSectionCode = new System.Windows.Forms.TextBox();
            this.uxDepartments = new System.Windows.Forms.ComboBox();
            this.uxFee = new System.Windows.Forms.TextBox();
            this.uxDescription = new System.Windows.Forms.TextBox();
            this.uxCourseName = new System.Windows.Forms.TextBox();
            this.uxCode = new System.Windows.Forms.TextBox();
            this.uxCourseId = new System.Windows.Forms.TextBox();
            this.uxSectionId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSectionOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.uxSectionGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.uxCourseOk = new System.Windows.Forms.Button();
            this.uxCoursesGrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSectionGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxCoursesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // uxEndDate
            // 
            this.uxEndDate.Location = new System.Drawing.Point(184, 209);
            this.uxEndDate.Name = "uxEndDate";
            this.uxEndDate.Size = new System.Drawing.Size(219, 20);
            this.uxEndDate.TabIndex = 67;
            this.toolTip1.SetToolTip(this.uxEndDate, "Select an End Date");
            // 
            // uxStartDate
            // 
            this.uxStartDate.Location = new System.Drawing.Point(184, 174);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(219, 20);
            this.uxStartDate.TabIndex = 66;
            this.toolTip1.SetToolTip(this.uxStartDate, "Select a Start Date");
            // 
            // uxRoomNumber
            // 
            this.uxRoomNumber.Location = new System.Drawing.Point(184, 243);
            this.uxRoomNumber.Name = "uxRoomNumber";
            this.uxRoomNumber.Size = new System.Drawing.Size(154, 20);
            this.uxRoomNumber.TabIndex = 65;
            this.toolTip1.SetToolTip(this.uxRoomNumber, "Enter Room Number");
            // 
            // uxCourses
            // 
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.Location = new System.Drawing.Point(184, 103);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(283, 21);
            this.uxCourses.TabIndex = 64;
            this.toolTip1.SetToolTip(this.uxCourses, "Select a Course");
            // 
            // uxSectionCode
            // 
            this.uxSectionCode.Location = new System.Drawing.Point(184, 139);
            this.uxSectionCode.Name = "uxSectionCode";
            this.uxSectionCode.Size = new System.Drawing.Size(154, 20);
            this.uxSectionCode.TabIndex = 61;
            this.toolTip1.SetToolTip(this.uxSectionCode, "Enter Section Course");
            // 
            // uxDepartments
            // 
            this.uxDepartments.FormattingEnabled = true;
            this.uxDepartments.Location = new System.Drawing.Point(176, 243);
            this.uxDepartments.Name = "uxDepartments";
            this.uxDepartments.Size = new System.Drawing.Size(206, 21);
            this.uxDepartments.TabIndex = 46;
            this.toolTip1.SetToolTip(this.uxDepartments, "Select a Department");
            // 
            // uxFee
            // 
            this.uxFee.Location = new System.Drawing.Point(176, 210);
            this.uxFee.Name = "uxFee";
            this.uxFee.Size = new System.Drawing.Size(154, 20);
            this.uxFee.TabIndex = 52;
            this.toolTip1.SetToolTip(this.uxFee, "Enter Course Fee");
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(176, 175);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(257, 20);
            this.uxDescription.TabIndex = 51;
            this.toolTip1.SetToolTip(this.uxDescription, "Enter Course Description");
            // 
            // uxCourseName
            // 
            this.uxCourseName.Location = new System.Drawing.Point(176, 140);
            this.uxCourseName.Name = "uxCourseName";
            this.uxCourseName.Size = new System.Drawing.Size(257, 20);
            this.uxCourseName.TabIndex = 50;
            this.toolTip1.SetToolTip(this.uxCourseName, "Enter Course Name");
            // 
            // uxCode
            // 
            this.uxCode.Location = new System.Drawing.Point(176, 105);
            this.uxCode.Name = "uxCode";
            this.uxCode.Size = new System.Drawing.Size(154, 20);
            this.uxCode.TabIndex = 4;
            this.toolTip1.SetToolTip(this.uxCode, "Enter Course Code");
            // 
            // uxCourseId
            // 
            this.uxCourseId.Location = new System.Drawing.Point(176, 66);
            this.uxCourseId.Name = "uxCourseId";
            this.uxCourseId.Size = new System.Drawing.Size(154, 20);
            this.uxCourseId.TabIndex = 53;
            this.toolTip1.SetToolTip(this.uxCourseId, "Course Id (Read-only)");
            // 
            // uxSectionId
            // 
            this.uxSectionId.Location = new System.Drawing.Point(184, 65);
            this.uxSectionId.Name = "uxSectionId";
            this.uxSectionId.Size = new System.Drawing.Size(154, 20);
            this.uxSectionId.TabIndex = 55;
            this.toolTip1.SetToolTip(this.uxSectionId, "Course Section Id (Read-only)");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Room Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Section Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(119, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "UPDATE COURSE SECTION INFO";
            // 
            // uxSectionOk
            // 
            this.uxSectionOk.Location = new System.Drawing.Point(218, 279);
            this.uxSectionOk.Name = "uxSectionOk";
            this.uxSectionOk.Size = new System.Drawing.Size(95, 23);
            this.uxSectionOk.TabIndex = 5;
            this.uxSectionOk.Text = "Update &Section";
            this.uxSectionOk.UseVisualStyleBackColor = true;
            this.uxSectionOk.Click += new System.EventHandler(this.uxSectionOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.uxEndDate);
            this.panel2.Controls.Add(this.uxSectionId);
            this.panel2.Controls.Add(this.uxStartDate);
            this.panel2.Controls.Add(this.uxRoomNumber);
            this.panel2.Controls.Add(this.uxCourses);
            this.panel2.Controls.Add(this.uxSectionCode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.uxSectionOk);
            this.panel2.Location = new System.Drawing.Point(486, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 322);
            this.panel2.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Course Section ID:";
            // 
            // uxSectionGrid
            // 
            this.uxSectionGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.uxSectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSectionGrid.Location = new System.Drawing.Point(486, 327);
            this.uxSectionGrid.MultiSelect = false;
            this.uxSectionGrid.Name = "uxSectionGrid";
            this.uxSectionGrid.Size = new System.Drawing.Size(503, 280);
            this.uxSectionGrid.TabIndex = 6;
            this.uxSectionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxSectionList_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Course Fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Course Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(125, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "UPDATE COURSE INFO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.uxCourseId);
            this.panel1.Controls.Add(this.uxDepartments);
            this.panel1.Controls.Add(this.uxFee);
            this.panel1.Controls.Add(this.uxDescription);
            this.panel1.Controls.Add(this.uxCourseName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uxCode);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.uxCourseOk);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 322);
            this.panel1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Course ID:";
            // 
            // uxCourseOk
            // 
            this.uxCourseOk.Location = new System.Drawing.Point(197, 280);
            this.uxCourseOk.Name = "uxCourseOk";
            this.uxCourseOk.Size = new System.Drawing.Size(90, 23);
            this.uxCourseOk.TabIndex = 4;
            this.uxCourseOk.Text = "Update &Course";
            this.uxCourseOk.UseVisualStyleBackColor = true;
            this.uxCourseOk.Click += new System.EventHandler(this.uxCourseOk_Click);
            // 
            // uxCoursesGrid
            // 
            this.uxCoursesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uxCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxCoursesGrid.Location = new System.Drawing.Point(1, 327);
            this.uxCoursesGrid.MultiSelect = false;
            this.uxCoursesGrid.Name = "uxCoursesGrid";
            this.uxCoursesGrid.Size = new System.Drawing.Size(479, 280);
            this.uxCoursesGrid.TabIndex = 4;
            this.uxCoursesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxCoursesList_CellClick);
            // 
            // UpdateCourseAndSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uxSectionGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxCoursesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateCourseAndSection";
            this.ShowIcon = false;
            this.Text = "Update Course And Section";
            this.Load += new System.EventHandler(this.UpdateCourseAndSection_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSectionGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxCoursesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker uxEndDate;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.TextBox uxRoomNumber;
        private System.Windows.Forms.ComboBox uxCourses;
        private System.Windows.Forms.TextBox uxSectionCode;
        private System.Windows.Forms.ComboBox uxDepartments;
        private System.Windows.Forms.TextBox uxFee;
        private System.Windows.Forms.TextBox uxDescription;
        private System.Windows.Forms.TextBox uxCourseName;
        private System.Windows.Forms.TextBox uxCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSectionOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView uxSectionGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxCourseOk;
        private System.Windows.Forms.DataGridView uxCoursesGrid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox uxSectionId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox uxCourseId;
    }
}