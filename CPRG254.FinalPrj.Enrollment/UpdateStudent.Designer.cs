namespace CPRG254.FinalPrj.Enrollment
{
    partial class UpdateStudent
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
            this.uxStudents = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uxCity = new System.Windows.Forms.TextBox();
            this.uxProvince = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxID = new System.Windows.Forms.TextBox();
            this.uxAddress = new System.Windows.Forms.TextBox();
            this.uxEmail = new System.Windows.Forms.TextBox();
            this.uxPostalCode = new System.Windows.Forms.TextBox();
            this.uxDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxStudents)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxStudents
            // 
            this.uxStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxStudents.EnableHeadersVisualStyles = false;
            this.uxStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uxStudents.Location = new System.Drawing.Point(0, 0);
            this.uxStudents.MultiSelect = false;
            this.uxStudents.Name = "uxStudents";
            this.uxStudents.Size = new System.Drawing.Size(752, 263);
            this.uxStudents.TabIndex = 44;
            this.uxStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxStudents_CellClick);
            this.uxStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxStudents_CellContentClick);
            this.uxStudents.SelectionChanged += new System.EventHandler(this.uxStudents_SelectionChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 263);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(752, 3);
            this.splitter1.TabIndex = 45;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uxClear);
            this.panel3.Controls.Add(this.uxFirstName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.uxCity);
            this.panel3.Controls.Add(this.uxProvince);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.uxID);
            this.panel3.Controls.Add(this.uxAddress);
            this.panel3.Controls.Add(this.uxEmail);
            this.panel3.Controls.Add(this.uxPostalCode);
            this.panel3.Controls.Add(this.uxDepartment);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.uxUpdate);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.uxLastName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.uxPhone);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 309);
            this.panel3.TabIndex = 46;
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(161, 259);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 25;
            this.uxClear.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.uxClear, "Clear Input Text Box Value");
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(134, 139);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(132, 20);
            this.uxFirstName.TabIndex = 24;
            this.toolTip1.SetToolTip(this.uxFirstName, "Enter a New First Name to Update");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Province:";
            // 
            // uxCity
            // 
            this.uxCity.Location = new System.Drawing.Point(448, 62);
            this.uxCity.Name = "uxCity";
            this.uxCity.Size = new System.Drawing.Size(132, 20);
            this.uxCity.TabIndex = 30;
            this.toolTip1.SetToolTip(this.uxCity, "Enter new City");
            // 
            // uxProvince
            // 
            this.uxProvince.FormattingEnabled = true;
            this.uxProvince.Location = new System.Drawing.Point(448, 98);
            this.uxProvince.Name = "uxProvince";
            this.uxProvince.Size = new System.Drawing.Size(132, 21);
            this.uxProvince.TabIndex = 32;
            this.toolTip1.SetToolTip(this.uxProvince, "Select Province");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Department:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(57, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 27);
            this.label11.TabIndex = 43;
            this.label11.Text = "UPDATE STUDENT DATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Student ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Postal Code:";
            // 
            // uxID
            // 
            this.uxID.Location = new System.Drawing.Point(134, 97);
            this.uxID.Name = "uxID";
            this.uxID.Size = new System.Drawing.Size(132, 20);
            this.uxID.TabIndex = 42;
            this.toolTip1.SetToolTip(this.uxID, "Enter Student ID to Modify the Student Data");
            // 
            // uxAddress
            // 
            this.uxAddress.Location = new System.Drawing.Point(448, 26);
            this.uxAddress.Name = "uxAddress";
            this.uxAddress.Size = new System.Drawing.Size(266, 20);
            this.uxAddress.TabIndex = 28;
            this.toolTip1.SetToolTip(this.uxAddress, "Enter new Student Address");
            // 
            // uxEmail
            // 
            this.uxEmail.Location = new System.Drawing.Point(448, 219);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(176, 20);
            this.uxEmail.TabIndex = 38;
            this.toolTip1.SetToolTip(this.uxEmail, "Update Email Address");
            // 
            // uxPostalCode
            // 
            this.uxPostalCode.Location = new System.Drawing.Point(448, 140);
            this.uxPostalCode.Name = "uxPostalCode";
            this.uxPostalCode.Size = new System.Drawing.Size(132, 20);
            this.uxPostalCode.TabIndex = 34;
            this.toolTip1.SetToolTip(this.uxPostalCode, "Enter Postal to Update");
            // 
            // uxDepartment
            // 
            this.uxDepartment.FormattingEnabled = true;
            this.uxDepartment.Location = new System.Drawing.Point(448, 259);
            this.uxDepartment.Name = "uxDepartment";
            this.uxDepartment.Size = new System.Drawing.Size(176, 21);
            this.uxDepartment.TabIndex = 40;
            this.toolTip1.SetToolTip(this.uxDepartment, "Select a Department");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address:";
            // 
            // uxUpdate
            // 
            this.uxUpdate.Location = new System.Drawing.Point(161, 221);
            this.uxUpdate.Name = "uxUpdate";
            this.uxUpdate.Size = new System.Drawing.Size(75, 23);
            this.uxUpdate.TabIndex = 22;
            this.uxUpdate.Text = "&Update";
            this.uxUpdate.UseVisualStyleBackColor = true;
            this.uxUpdate.Click += new System.EventHandler(this.uxUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Phone:";
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(134, 177);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(132, 20);
            this.uxLastName.TabIndex = 26;
            this.toolTip1.SetToolTip(this.uxLastName, "Enter a New Last Name to Update");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name:";
            // 
            // uxPhone
            // 
            this.uxPhone.Location = new System.Drawing.Point(448, 181);
            this.uxPhone.Name = "uxPhone";
            this.uxPhone.Size = new System.Drawing.Size(132, 20);
            this.uxPhone.TabIndex = 36;
            this.toolTip1.SetToolTip(this.uxPhone, "Enter Phone Number");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.uxStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 575);
            this.panel1.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateStudent";
            this.Text = "Update Existing Student";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.Click += new System.EventHandler(this.UpdateStudent_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateStudent_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.uxStudents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxCity;
        private System.Windows.Forms.ComboBox uxProvince;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxID;
        private System.Windows.Forms.TextBox uxAddress;
        private System.Windows.Forms.TextBox uxEmail;
        private System.Windows.Forms.TextBox uxPostalCode;
        private System.Windows.Forms.ComboBox uxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView uxStudents;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button uxClear;
    }
}