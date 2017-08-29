namespace CPRG254.FinalPrj.Enrollment
{
    partial class AddCourseAndSection
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
            this.uxCoursesGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxDepartments = new System.Windows.Forms.ComboBox();
            this.uxFee = new System.Windows.Forms.TextBox();
            this.uxDescription = new System.Windows.Forms.TextBox();
            this.uxCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uxCourseOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxEndDate = new System.Windows.Forms.DateTimePicker();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.uxRoomNumber = new System.Windows.Forms.TextBox();
            this.uxCourses = new System.Windows.Forms.ComboBox();
            this.uxSectionCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSectionOk = new System.Windows.Forms.Button();
            this.uxSectionGrid = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxCoursesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSectionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCoursesGrid
            // 
            this.uxCoursesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxCoursesGrid.Location = new System.Drawing.Point(-5, 270);
            this.uxCoursesGrid.Name = "uxCoursesGrid";
            this.uxCoursesGrid.Size = new System.Drawing.Size(479, 280);
            this.uxCoursesGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 265);
            this.panel1.TabIndex = 1;
            // 
            // uxDepartments
            // 
            this.uxDepartments.FormattingEnabled = true;
            this.uxDepartments.Location = new System.Drawing.Point(175, 189);
            this.uxDepartments.Name = "uxDepartments";
            this.uxDepartments.Size = new System.Drawing.Size(206, 21);
            this.uxDepartments.TabIndex = 46;
            this.toolTip1.SetToolTip(this.uxDepartments, "Select a Department");
            // 
            // uxFee
            // 
            this.uxFee.Location = new System.Drawing.Point(175, 156);
            this.uxFee.Name = "uxFee";
            this.uxFee.Size = new System.Drawing.Size(154, 20);
            this.uxFee.TabIndex = 52;
            this.toolTip1.SetToolTip(this.uxFee, "Enter Course Fee");
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(175, 121);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(257, 20);
            this.uxDescription.TabIndex = 51;
            this.toolTip1.SetToolTip(this.uxDescription, "Enter Course Description");
            // 
            // uxCourseName
            // 
            this.uxCourseName.Location = new System.Drawing.Point(175, 86);
            this.uxCourseName.Name = "uxCourseName";
            this.uxCourseName.Size = new System.Drawing.Size(154, 20);
            this.uxCourseName.TabIndex = 50;
            this.toolTip1.SetToolTip(this.uxCourseName, "Enter Course Name");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Course Fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Course Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Code:";
            // 
            // uxCode
            // 
            this.uxCode.Location = new System.Drawing.Point(175, 51);
            this.uxCode.Name = "uxCode";
            this.uxCode.Size = new System.Drawing.Size(154, 20);
            this.uxCode.TabIndex = 4;
            this.toolTip1.SetToolTip(this.uxCode, "Enter Course Code");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(170, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "ADD COURSE";
            // 
            // uxCourseOk
            // 
            this.uxCourseOk.Location = new System.Drawing.Point(196, 226);
            this.uxCourseOk.Name = "uxCourseOk";
            this.uxCourseOk.Size = new System.Drawing.Size(75, 23);
            this.uxCourseOk.TabIndex = 4;
            this.uxCourseOk.Text = "Add &Course";
            this.uxCourseOk.UseVisualStyleBackColor = true;
            this.uxCourseOk.Click += new System.EventHandler(this.uxCourseOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.uxEndDate);
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
            this.panel2.Location = new System.Drawing.Point(480, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 265);
            this.panel2.TabIndex = 3;
            // 
            // uxEndDate
            // 
            this.uxEndDate.Location = new System.Drawing.Point(202, 156);
            this.uxEndDate.Name = "uxEndDate";
            this.uxEndDate.Size = new System.Drawing.Size(219, 20);
            this.uxEndDate.TabIndex = 67;
            this.toolTip1.SetToolTip(this.uxEndDate, "Select an End Date");
            // 
            // uxStartDate
            // 
            this.uxStartDate.Location = new System.Drawing.Point(202, 121);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(219, 20);
            this.uxStartDate.TabIndex = 66;
            this.toolTip1.SetToolTip(this.uxStartDate, "Select a Start Date");
            // 
            // uxRoomNumber
            // 
            this.uxRoomNumber.Location = new System.Drawing.Point(202, 190);
            this.uxRoomNumber.Name = "uxRoomNumber";
            this.uxRoomNumber.Size = new System.Drawing.Size(154, 20);
            this.uxRoomNumber.TabIndex = 65;
            this.toolTip1.SetToolTip(this.uxRoomNumber, "Enter Room Number");
            // 
            // uxCourses
            // 
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.Location = new System.Drawing.Point(202, 50);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(219, 21);
            this.uxCourses.TabIndex = 64;
            this.toolTip1.SetToolTip(this.uxCourses, "Select a Course");
            // 
            // uxSectionCode
            // 
            this.uxSectionCode.Location = new System.Drawing.Point(202, 86);
            this.uxSectionCode.Name = "uxSectionCode";
            this.uxSectionCode.Size = new System.Drawing.Size(154, 20);
            this.uxSectionCode.TabIndex = 61;
            this.toolTip1.SetToolTip(this.uxSectionCode, "Enter Section Course");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Room Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "End Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Section Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "ADD SECTION";
            // 
            // uxSectionOk
            // 
            this.uxSectionOk.Location = new System.Drawing.Point(236, 226);
            this.uxSectionOk.Name = "uxSectionOk";
            this.uxSectionOk.Size = new System.Drawing.Size(75, 23);
            this.uxSectionOk.TabIndex = 5;
            this.uxSectionOk.Text = "Add &Section";
            this.uxSectionOk.UseVisualStyleBackColor = true;
            this.uxSectionOk.Click += new System.EventHandler(this.uxSectionOk_Click);
            // 
            // uxSectionGrid
            // 
            this.uxSectionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uxSectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSectionGrid.Location = new System.Drawing.Point(480, 270);
            this.uxSectionGrid.Name = "uxSectionGrid";
            this.uxSectionGrid.Size = new System.Drawing.Size(503, 280);
            this.uxSectionGrid.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // AddCourseAndSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxSectionGrid);
            this.Controls.Add(this.uxCoursesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddCourseAndSection";
            this.Text = "Add Course And Section";
            this.Load += new System.EventHandler(this.AddCourseAndSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxCoursesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSectionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxCoursesGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView uxSectionGrid;
        private System.Windows.Forms.Button uxCourseOk;
        private System.Windows.Forms.Button uxSectionOk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxDepartments;
        private System.Windows.Forms.TextBox uxFee;
        private System.Windows.Forms.TextBox uxDescription;
        private System.Windows.Forms.TextBox uxCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxCode;
        private System.Windows.Forms.ComboBox uxCourses;
        private System.Windows.Forms.TextBox uxSectionCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uxRoomNumber;
        private System.Windows.Forms.DateTimePicker uxEndDate;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}